using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentsWinForm.Models.Records
{
    public class Ajandekok
    {
        private string present_id;

        public string Present_id
        {
            get
            {
                return present_id;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("Present ID can not be null!");
                }
                else if (value.Length > 6)
                {
                    throw new IdTooLongException("The ID can not be longer than 6 characters!");
                }
                present_id = value;
            }
        }


        private string present_name;

        public string Present_name
        {
            get
            {
                return present_name;
            }
            set
            {
                if (value.Length == 0 || value == null || value.Length > 250)
                {
                    throw new PresentNameNotValidException("The present name should be max. 250 characters long!");
                }
                present_name = value;
            }
        }

        private int manufacturer_id;

        public int Manufacturer_id
        {
            get
            {
                return manufacturer_id;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Manufacturer id can not be null!");
                }
                manufacturer_id = value;
            }
        }

        private string present_color;

        public string Present_color
        {
            get
            {
                return present_color;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("Color can not be null!");
                }
                present_color = value;
            }
        }

        private string present_size;

        public string Present_size
        {
            get
            {
                return present_size;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Size can not be null!");
                }
                present_size = value;
            }
        }

        private int present_price;

        public int Present_price
        {
            get
            {
                return present_price;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The price can not be null!");
                }
                present_price = value;
            }
        }

        private int present_weight;

        public int Present_weight
        {
            get
            {
                return present_weight;
            }
            set
            {
                present_weight = value;
            }
        }





    }
}
