using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBI_Mgt_System
{
    public class room 
    {
        public int roomNum;
        public string name;
        public int people;
        public bool pet = false;
        public room() {
            this.roomNum = 0;
            this.name = "";
            this.people = 0;
            this.pet = false;
        }

        public void empty()
        {
            this.roomNum = 0;
            this.name = "";
            this.people = 0;
            this.pet = false;
        }
        public room MakeCopy()
        {
            room k = new room();
            k.roomNum = roomNum;
            k.name = name;
            k.people = people;
            k.pet = pet;
            return k;
        }
    }
}
