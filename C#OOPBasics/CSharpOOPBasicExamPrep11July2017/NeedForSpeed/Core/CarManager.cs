using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    public CarManager()
    {
        this.RegisteredCars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    public Dictionary<int, Car> RegisteredCars { get; set; }

    public Dictionary<int, Race> Races { get; set; }

    public Garage Garage { get; set; }

    public void Register(int carId, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        if (!this.RegisteredCars.ContainsKey(carId))
        {
            if (type == "Performance")
            {
                this.RegisteredCars.Add(carId, new PerformanceCar(carId, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
            else if (type == "Show")
            {
                this.RegisteredCars.Add(carId, new ShowCar(carId, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
        }
    }

    public string Check(int carId)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine(this.RegisteredCars[carId].ToString());
        
        return sb.ToString().Trim();
    }

    public void Open(int raceId, string type, int length, string route, int prizePool)
    {
        if (!this.Races.ContainsKey(raceId))
        {
            if (type == "Casual")
            {
                this.Races.Add(raceId, new CasualRace(length, route, prizePool));
            }
            else if (type == "Drag")
            {
                this.Races.Add(raceId, new DragRace(length, route, prizePool));
            }
            else if (type == "Drift")
            {
                this.Races.Add(raceId, new DriftRace(length, route, prizePool));
            }
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.Garage.ParkedCars.Any(pc => pc.Id == carId))
        {
            this.Races[raceId].Participants.Add(this.RegisteredCars[carId]);
        }
    }

    public string Start(int raceId)
    {
        var sb = new StringBuilder();

        if (this.Races.ContainsKey(raceId))
        {
            if (this.Races[raceId].Participants.Count > 0)
            {
                foreach (var participant in this.Races[raceId].Participants)
                {
                    if (this.Races[raceId].GetType().Name == "CasualRace")
                    {
                        participant.OverallPerformance = (participant.HorsePower / participant.Acceleration) + (participant.Suspension + participant.Durability);
                    }
                    else if (this.Races[raceId].GetType().Name == "DragRace")
                    {
                        participant.OverallPerformance = (participant.HorsePower / participant.Acceleration);
                    }
                    else
                    {
                        participant.OverallPerformance = (participant.Suspension + participant.Durability);
                    }
                }

                var counter = 1;

                sb.AppendLine($"{this.Races[raceId].Route} - {this.Races[raceId].Length}");

                foreach (var item in this.Races.Values)
                {
                    foreach (var participant in item.Participants.OrderByDescending(p => p.OverallPerformance))
                    {
                        var moneyWon = 0;

                        if (counter == 1)
                        {
                            moneyWon = (this.Races[raceId].PrizePool * 50) / 100;
                            sb.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.OverallPerformance}PP - ${moneyWon}");
                        }
                        else if (counter == 2)
                        {
                            moneyWon = (this.Races[raceId].PrizePool * 30) / 100;
                            sb.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.OverallPerformance}PP - ${moneyWon}");
                        }
                        else if (counter == 3)
                        {
                            moneyWon = (this.Races[raceId].PrizePool * 20) / 100;
                            sb.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.OverallPerformance}PP - ${moneyWon}");
                        }
                        counter++;
                        if (counter > 3)
                        {
                            break;
                        }
                    }
                    break;
                }
            }
            else
            {
                sb.AppendLine("Cannot start the race with zero participants.");
            }
        }
        return sb.ToString().Trim();
    }

    public void Park(int carId)
    {
        bool isInRace = false;
        foreach (var item in this.Races.Values)
        {
            if (item.Participants.Any(p => p.Id == carId))
            {
                isInRace = true;
            }
        }
        if (isInRace == false)
        {
            this.Garage.ParkedCars.Add(this.RegisteredCars[carId]);
        }
    }

    public void Unpark(int carId)
    {
        if (this.Garage.ParkedCars.Count > 0 && this.Garage.ParkedCars.Any(c => c.Id == carId))
        {
            this.Garage.ParkedCars = this.Garage.ParkedCars.Where(c => c.Id != carId).ToList();
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.Garage.ParkedCars.Count > 0)
        {
            foreach (var car in this.Garage.ParkedCars)
            {
                car.HorsePower += tuneIndex;
                car.Suspension += tuneIndex / 2;

                if (car.GetType().Name == "PerformanceCar")
                {
                    var performanceCar = (PerformanceCar)car;
                    performanceCar.AddOns.Add(addOn);
                }
                else
                {
                    var showCar = (ShowCar)car;
                    showCar.Stars += tuneIndex;
                }
            }
        }        
    }
}