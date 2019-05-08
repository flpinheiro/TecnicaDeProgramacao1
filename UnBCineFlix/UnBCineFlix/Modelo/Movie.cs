using System;
using System.Collections.Generic;
using System.Text;

namespace UnBCineFlix.Modelo
{
    class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public DateTime RealeseDate { get; set; }
        public string Information { get; set; }
        public string Rating { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
