using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuzyLotek;
using System.Windows.Forms;
using System.Threading;

namespace DuzyLotek.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestCheckUpdate()
		{
			Update update = new Update();
			string valueexpected = "Masz najnowszą wersję oprogramowania.";
			Assert.AreEqual(valueexpected, update.Check());
		}

		[TestMethod]
		public void TestgetRecordsFromDB()
		{
			Form1 form1 = new Form1();
			int value = 1;
			Assert.AreEqual(value, form1.getRecordsFromDBAndDisplay());
		}

		[TestMethod]
		public void TestTimerCallbackScores()
		{
			string[] values = LastScores.downloadDateAndScores();
			Assert.IsNotNull(values[0]);
		}

		[TestMethod]
		public void TestTimerCallbackDate()
		{
			string[] values = LastScores.downloadDateAndScores();
			Assert.IsNotNull(values[1]);
		}

		[TestMethod]
		public void TestGetDBConnection()
		{
			DatabaseConnect.conn.Close();
			DatabaseConnect databaseconnect = new DatabaseConnect();
			Assert.IsNotNull(databaseconnect.GetDBConnection());
		}

		[TestMethod]
		public void TestGetDBInstance()
		{
			Assert.IsNotNull(DatabaseConnect.getDbInstance());
			DatabaseConnect.conn.Close();
		}

		[TestMethod]
		public void TestGetVersion()
		{
			Update update = new Update();
			string version = update.getVersion();
			Assert.IsNotNull(DatabaseConnect.getDbInstance());
		}

		[TestMethod]
		public void TestNumberVersion()
		{
			Update update = new Update();
			string version = update.getVersion();
			Assert.AreEqual("1.02", version);
		}

		[TestMethod]
		public void TestreturnAllLines()
		{
			Assert.IsNotNull(InsertFromFile.returnAllLines());
		}

		[TestMethod]
		public void TestrandomScores()
		{
			Form1 form1 = new Form1();
			string emptystring = "";
			string numbers = form1.randomScores(49, 6);
			Assert.AreNotEqual(emptystring, numbers);
		}
	}
}