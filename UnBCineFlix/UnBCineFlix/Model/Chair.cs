using System;
using System.Collections.Generic;
using System.Text;

namespace UnBCineFlix.Model
{
    class Chair
    {
        public int ID { get; set; }
        //Coluna da cadeira no cinema
        public int Column { get; set; }
        //fileira da cadeira no cinema
        public char Row { get; set; }
        //status da cadeira na sessão do cinema
        //true->vendido
        //false->não vendido
        public bool Status { get; set; }

        public Chair(int column, char row, bool status = false)
        {
            Column = column;
            Row = row;
            Status = status; 
        }

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
