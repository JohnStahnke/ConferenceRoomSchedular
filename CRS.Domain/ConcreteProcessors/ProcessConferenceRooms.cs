using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CRS.Domain.ConcreteProcessors
{
    public class ProcessConferenceRooms : Abstract.IProcessConferenceRooms
    {

        public IEnumerable<CRS.Domain.ConcreteEntities.ConferenceRoom> ConferenceRooms
        {
            get
            {   
                List<CRS.Domain.ConcreteEntities.ConferenceRoom> objL;
                objL = new List<CRS.Domain.ConcreteEntities.ConferenceRoom>();
                string strSQLCode = @"Select ConferenceRoomID, ConferenceRoomName, ConferenceRoomFloor, ConferenceRoomLocation 
                                        From vConferenceRooms";
                System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
                try
                {
                    var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.Text, strSQLCode);
                    objCon.Open();
                    var objDR = objCmd.ExecuteReader();
                    while (objDR.Read())
                    {
                        ConcreteEntities.ConferenceRoom objCR = new ConcreteEntities.ConferenceRoom();
                        objCR.ConferenceRoomID = (int)objDR["ConferenceRoomID"];
                        objCR.ConferenceRoomName = (string)objDR["ConferenceRoomName"];
                        objCR.ConferenceRoomFloor = (int)objDR["ConferenceRoomFloor"];
                        objCR.ConferenceRoomLocation = (string)objDR["ConferenceRoomLocation"];
                        objL.Add(objCR);
                    }
                    objDR.Close();
                }
                catch{ throw;}
                finally { objCon.Close(); }
                return objL;
            }
        }

        public int InsConferenceRooms(ConcreteEntities.ConferenceRoom ConferenceRoom)
        {
            string strSQLCode = @"pInsConferenceRooms";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@ConferenceRoomName";
            objP1.SqlDbType = System.Data.SqlDbType.VarChar;
            objP1.Size = 100;
            objP1.Value = ConferenceRoom.ConferenceRoomName;
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@ConferenceRoomFloor";
            objP2.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP2.Value = ConferenceRoom.ConferenceRoomFloor;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@ConferenceRoomLocation";
            objP3.SqlDbType = System.Data.SqlDbType.VarChar;
            objP3.Size = 100;
            objP3.Value = ConferenceRoom.ConferenceRoomLocation;
            lstParms.Add(objP3);

            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        }


        public int UpdConferenceRooms(ConcreteEntities.ConferenceRoom ConferenceRoom)
        {
            string strSQLCode = @"pUpdConferenceRooms";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@ConferenceRoomID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(ConferenceRoom.ConferenceRoomID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@ConferenceRoomName";
            objP2.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP2.Size = 100;
            objP2.Value = ConferenceRoom.ConferenceRoomName;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@ConferenceRoomFloor";
            objP3.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP3.Value = Convert.ToInt32(ConferenceRoom.ConferenceRoomFloor);
            lstParms.Add(objP3);

            System.Data.SqlClient.SqlParameter objP4 = new System.Data.SqlClient.SqlParameter();
            objP4.Direction = System.Data.ParameterDirection.Input;
            objP4.ParameterName = "@ConferenceRoomLocation";
            objP4.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP4.Size = 100;
            objP4.Value = ConferenceRoom.ConferenceRoomFloor;
            lstParms.Add(objP4);

            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        }

        public int pDelConferenceRooms(int conferenceRmID)
        {
            string strSQLCode = @"pDelConferenceRooms";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@ConferenceRoomID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(conferenceRmID);
            lstParms.Add(objP1);

            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        
        }
    }
}
