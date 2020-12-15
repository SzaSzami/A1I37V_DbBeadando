using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using PresentsWinForm.Models.Records;

namespace PresentsWinForm.Models.Manager
{
    class PresentsTable : DatabaseConnection
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionstring = @"Data Source = 193.225.33.71;User Id = ORA_S1340;Password = EKE2020;";
            oc.ConnectionString = connectionstring;
            return oc;
        }

        public List<Ajandekok> Select()
        {
            List<Ajandekok> records = new List<Ajandekok>();
            OracleCommand command = new OracleCommand();

            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT PRESENT_ID, PRESENT_NAME, MANUFACTURER_ID, PRESENT_COLOR, PRESENT_SIZE, PRESENT_PRICE, PRESENT_WEIGHT FROM PRESENTS";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ajandekok presento = new Ajandekok();
                presento.Present_id = reader["PRESENT_ID"].ToString();
                presento.Present_name = reader["PRESENT_NAME"].ToString();
                presento.Manufacturer_id = int.Parse(reader["MANUFACTURER_ID"].ToString());
                presento.Present_color = reader["PRESENT_COLOR"].ToString();
                presento.Present_size = reader["PRESENT_SIZE"].ToString();
                presento.Present_price = int.Parse(reader["PRESENT_PRICE"].ToString());
                presento.Present_weight = int.Parse(reader["PRESENT_WEIGHT"].ToString());

                records.Add(presento);
            }
            reader.Close();
            return records;

        }


        public int Delete(Ajandekok record)
        {

            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM PRESENTS WHERE PRESENT_ID = :Present_id"
            };

            OracleParameter PRESENT_IDParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":Present_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Present_id
            };
            command.Parameters.Add(PRESENT_IDParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            return affectedRows;
        }

        public int Insert(Ajandekok record)
        {

            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO PRESENTS(PRESENT_ID, PRESENT_NAME, MANUFACTURER_ID, PRESENT_COLOR, PRESENT_SIZE, PRESENT_PRICE, PRESENT_WEIGHT)" +
                "VALUES(:Present_id, :Present_name, :Manufacturer_id, :Present_color, :Present_size, :Present_price, :Present_weight)";

            OracleParameter ppresent_id = new OracleParameter()
            {
               ParameterName = ":Present_id",
               OracleDbType = OracleDbType.Char,
               Direction = System.Data.ParameterDirection.Input,
               Value = record.Present_id
            };
            command.Parameters.Add(ppresent_id);

            OracleParameter ppresent_name = new OracleParameter()
            {
            ParameterName = ":Present_name",
            OracleDbType = OracleDbType.Varchar2,
            Direction = System.Data.ParameterDirection.Input,
            Value = record.Present_name
            };
            command.Parameters.Add(ppresent_name);

            OracleParameter pmanufacturer_id = new OracleParameter()
            {
            ParameterName = ":Manufacturer_id",
            OracleDbType = OracleDbType.Int32,
            Direction = System.Data.ParameterDirection.Input,
            Value = record.Manufacturer_id
            };
            command.Parameters.Add(pmanufacturer_id);

            OracleParameter ppresent_color = new OracleParameter()
            {
            ParameterName = ":Present_color",
            OracleDbType = OracleDbType.Varchar2,
            Direction = System.Data.ParameterDirection.Input,
            Value = record.Present_color
            };
            command.Parameters.Add(ppresent_color);


            OracleParameter ppresent_size = new OracleParameter()
            {
            ParameterName = ":Present_size",
            OracleDbType = OracleDbType.Varchar2,
            Direction = System.Data.ParameterDirection.Input,
            Value = record.Present_size
            };
            command.Parameters.Add(ppresent_size);

            OracleParameter ppresent_price = new OracleParameter()
            {
            ParameterName = ":Present_price",
            OracleDbType = OracleDbType.Long,
            Direction = System.Data.ParameterDirection.Input,
            Value = record.Present_price
            };
            command.Parameters.Add(ppresent_price);

            OracleParameter ppresent_weight = new OracleParameter()
            {
                ParameterName = ":Present_weight",
                OracleDbType = OracleDbType.Int32,
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Present_weight
            };
            command.Parameters.Add(ppresent_weight);


            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };
            return command.ExecuteNonQuery();
        }

        public bool CheckPresentId(string Present_id)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_presentid"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter Present_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_PRESENT_ID",
                Direction = System.Data.ParameterDirection.Input,
                Value = Present_id
            };
            command.Parameters.Add(Present_idParameter);
            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());
                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }






    }
}
