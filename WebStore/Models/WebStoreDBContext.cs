using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;


namespace WebStore.Models
{
	public class WebStoreDBContext
	{
		public string ConnectionString { get; set; }

		public WebStoreDBContext(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		//private MySqlConnection GetConnection() {
			//return new MySqlConnection();


		}




	}

