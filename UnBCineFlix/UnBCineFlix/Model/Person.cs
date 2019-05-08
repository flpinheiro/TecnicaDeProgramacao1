using System;
using System.Collections.Generic;
using System.Text;

namespace UnBCineFlix.Model
{
    abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TelePhone { get; set; }
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Create Function, must be overrided
        /// </summary>
        public abstract void Create();

        /// <summary>
        /// Read function, must be overrided
        /// </summary>
        public abstract void Read();
        /// <summary>
        /// Update function, must be overrided
        /// </summary>
        public abstract void Update();
        /// <summary>
        /// Delete function, must be overrided
        /// </summary>
        public abstract void Delete();

    }
}
