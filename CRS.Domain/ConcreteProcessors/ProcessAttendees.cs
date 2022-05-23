using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteProcessors
{
    public class ProcessAttendees : CRS.Domain.Abstract.IProcessAttendees
    {
        public IEnumerable<ConcreteEntities.Attendee> Attendees
        {
            get
            {
                List<CRS.Domain.ConcreteEntities.Attendee> objL;
                objL = new List<CRS.Domain.ConcreteEntities.Attendee>();
                string strSQLCode = @"Select AttendeeID, AttendeeName, AttendeeEmail, AttendeePhone
                                        From [dbo].[vAttendees]";
                System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
                try
                {
                    var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.Text, strSQLCode);
                    objCon.Open();
                    var objDR = objCmd.ExecuteReader();
                    while (objDR.Read())
                    {
                        ConcreteEntities.Attendee objA = new ConcreteEntities.Attendee();
                        objA.AttendeeID = (int)objDR["AttendeeID"];
                        objA.AttendeeName = (string)objDR["AttendeeName"];
                        objA.AttendeeEmail = (string)objDR["AttendeeEmail"];
                        objA.AttendeePhone = (string)objDR["AttendeePhone"];
                        objL.Add(objA);
                    }
                    objDR.Close();
                }
                catch { throw; }
                finally 
                { 
                  objCon.Close(); 
                }
                return objL;
            }
        }

        public int InsAttendees(ConcreteEntities.Attendee Attendee)
        {
            string strSQLCode = @"pInsAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@AttendeeName";
            objP1.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP1.Size = 100;
            objP1.Value = Attendee.AttendeeName;
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@AttendeeEmail";
            objP2.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP2.Size = 100;
            objP2.Value = Attendee.AttendeeEmail;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@AttendeePhone";
            objP3.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP3.Size = 100;
            objP3.Value = Attendee.AttendeePhone;
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

        public int UpdAttendees(ConcreteEntities.Attendee Attendee)
        {
            string strSQLCode = @"pUpdAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@AttendeeID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(Attendee.AttendeeID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@AttendeeName";
            objP2.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP2.Size = 100;
            objP2.Value = Attendee.AttendeeName;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@AttendeeEmail";
            objP3.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP3.Size = 100;
            objP3.Value = Attendee.AttendeeEmail;
            lstParms.Add(objP3);

            System.Data.SqlClient.SqlParameter objP4 = new System.Data.SqlClient.SqlParameter();
            objP4.Direction = System.Data.ParameterDirection.Input;
            objP4.ParameterName = "@AttendeePhone";
            objP4.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP4.Size = 100;
            objP4.Value = Attendee.AttendeePhone;
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

        public int pDelAttendees(int AttendeeID)
        {
            string strSQLCode = @"pDelAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@AttendeeID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(AttendeeID);
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
