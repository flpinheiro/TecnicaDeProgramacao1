using System;
using System.Collections.Generic;
using System.Text;

namespace UnBCineFlix.Modelo
{
    class Session
    {
        public int SessionID { get; set; }
        public DateTime SessionDay { get; set; }
        public MovieTheater MovieTheater { get; set; }
        public Movie Movie { get; set; }


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
