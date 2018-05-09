using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lake<T> 
    : IEnumerable<T>
{
    private T[] stones;
    private T[] jumpedStones;
    

    public Lake(T[] stones)
    {
        this.stones = new T[stones.Length];
        this.jumpedStones = new T[stones.Length];
        AddStones(stones);
        JumpOnStones();
    }

    private void JumpOnStones()
    {
        var count = 0;

        for (int i = 0; i < this.stones.Length; i++)
        {
            if (i % 2 == 0)
            {
                this.jumpedStones[count] = this.stones[i];
                count++;
            }
        }

        for (int i = this.stones.Length - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                this.jumpedStones[count] = this.stones[i];
                count++;
            }
        }
    }

    private void AddStones(T[] stones)
    {
        for (int i = 0; i < stones.Length; i++)
        {
            this.stones[i] = stones[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        return this.GetEnumerator();
    }    

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        for (int i = 0; i < this.stones.Length; i++)
        {
            yield return this.stones[i];
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append(string.Join(", ", this.jumpedStones));

        return sb.ToString().Trim();
    }
}