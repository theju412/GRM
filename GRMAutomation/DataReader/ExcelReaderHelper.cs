﻿using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace GRMAutomation.DataReader
{
    public class ExcelReaderHelper
    {
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static IExcelDataReader reader;

        static ExcelReaderHelper()
        {
            _cache = new Dictionary<string, IExcelDataReader>();
        }

        private static IExcelDataReader GetExcelReader(string xlPath, string sheetName)
        {
            if (_cache.ContainsKey(sheetName))
            {
                reader = _cache[sheetName];
            }
            else
            {
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cache.Add(sheetName, reader);
            }
            return reader;
        }

        public static int GetTotalRows(string xlPath, string sheetName)
        {
            IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
            return _reader.AsDataSet().Tables[sheetName].Rows.Count;

        }

        public static object GetCellData(string xlPath, string sheetName, int row, int column)
        {
            //need to add in master below line.
            _cache.Clear(); 
            IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
            DataTable table = _reader.AsDataSet().Tables[sheetName];
            return table.Rows[row][column];
        }


        private static object GetData(Type type, object data)
        {
            switch (type.Name)
            {
                case "String":
                    return data.ToString();
                case "Double":
                    return Convert.ToDouble(data);
                case "DateTime":
                    return Convert.ToDateTime(data);
                default:
                    return data.ToString();
            }
        }
    }
}
