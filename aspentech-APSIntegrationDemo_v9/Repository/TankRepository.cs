using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APSIntegration.Repository
{
    public class TankRepository
    {

        public void ImportTank()
        {

            ////Crate set and table 
            //DataSet ds = new DataSet();
            //DataTable sourceData = new DataTable();

            //DataColumn column;

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "tank";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "prop";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.Int32");
            //column.ColumnName = "value";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.DateTime");
            //column.ColumnName = "date_";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "source";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.DateTime");
            //column.ColumnName = "x_updated";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);

            //// ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "x_by";
            //// Add the Column to the DataColumnCollection.
            //sourceData.Columns.Add(column);




            //ds.Tables.Add(sourceData);

            //////read xml file and values

            ////var document = new XDocument();

            ////document = XDocument.Load("Strings.Xml");

            ////var xdates = from xdate in document.Descendants("xdate") select xdate;

            ////var invdate = new DateTime();

            ////var localdate = DateTime.Now;

            ////foreach (XElement xdate in xdates)
            ////{

            ////    invdate = Convert.ToDateTime(xdate.Value);

            ////}


            ////var xtanks = from xtank in document.Descendants("xtank") select xtank;

            ////foreach (XElement xtank in xtanks)
            ////{
            ////    var tank = (string)xtank.Element("xname").Value;

            ////    var xprops = from xprop in xtank.Descendants("xprop") select xprop;

            ////    foreach (XElement xprop in xprops)

            ////    {


            ////        var prop = (string)xprop.Element("xname").Value;
            ////        var value = Convert.ToDouble(xprop.Element("xvalue").Value);

            ////        DataRow newprop = ds.Tables[0].NewRow();

            ////        newprop["tank"] = tank;

            ////        newprop["prop"] = prop;

            ////        newprop["value"] = value;

            ////        newprop["date_"] = invdate;

            ////        newprop["source"] = "myapp";

            ////        newprop["x_updated"] = localdate;
            ////        newprop["x_by"] = "CORP\\HERNANDD";

            ////        ds.Tables[0].Rows.Add(newprop);


            ////    }


            ////}

            ////connect to database      



            //using (SqlConnection con = new SqlConnection("Server=hernandd1\\sqlexpress; Database=demo87;"
            //  + "Trusted_Connection=True; "))
            //{


            //    con.Open();

            //    // clear existing values for that date:

            //    string delete = "delete  from [demo87].[dbo].[ORION_MGR_TNKINV_IMPORT]  where date_='" + Convert.ToString(invdate) + "'";

            //    SqlCommand command = new SqlCommand(delete, con);
            //    SqlDataReader reader = command.ExecuteReader();
            //    reader.Close();

            //    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con.ConnectionString))
            //    {

            //        bulkCopy.ColumnMappings.Add("tank", "TANK");
            //        bulkCopy.ColumnMappings.Add("prop", "PROP");
            //        bulkCopy.ColumnMappings.Add("value", "PLANT_VALUE");
            //        bulkCopy.ColumnMappings.Add("value", "VALUE_");
            //        bulkCopy.ColumnMappings.Add("date_", "DATE_");
            //        bulkCopy.ColumnMappings.Add("source", "SOURCE");
            //        bulkCopy.ColumnMappings.Add("x_updated", "X_UPDATED");
            //        bulkCopy.ColumnMappings.Add("x_by", "X_BY");
            //        bulkCopy.DestinationTableName = "ORION_MGR_TNKINV_IMPORT";
            //        bulkCopy.WriteToServer(ds.Tables[0]);

            //    }

            //}

            ////Launch orion dialog box   

            //var pss = new orion.Application();



            //pss.LaunchDlgAuditInventories(invdate);


            //pss = null;


        }
    }
}