using System;
using System.Collections.Generic;
using System.Text;

namespace Borlay.Repositories
{
    public interface IIndex
    {
        IndexLevel Level { get; }
    }

    public class Index : IIndex
    {
        public IndexLevel Level { get; set; }
    }

    public interface IOrderIndex
    {
        long GetScore();
    }

    public class ScoreIndex : Index, IOrderIndex
    {
        public long Score { get; set; }

        public virtual long GetScore()
        {
            return Score;
        }
    }

    public class DateIndex : Index, IOrderIndex
    {
        public DateTime Date { get; set; }

        public virtual long GetScore()
        {
            var offset = new DateTimeOffset(Date);
            var score = offset.ToUnixTimeMilliseconds();
            return score;
        }
    }

    public enum DataType : byte
    {
        None = 0,
        Entity = 1,
        Index = 2
    }

    public enum IndexLevel : byte
    {
        None = 0,
        Entity = 1,
        Parent = 2,
    }

    [Flags]
    public enum OrderType
    {
        None = 0,
        Asc = 1,
        Desc = 2
    }
}
