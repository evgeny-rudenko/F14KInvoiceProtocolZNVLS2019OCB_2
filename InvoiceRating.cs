// Decompiled with JetBrains decompiler
// Type: F14KInvoiceProtocolZNVLS2019OCB.InvoiceRating
// Assembly: F14KInvoiceProtocolZNVLS2019OCB_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 30686E9C-3056-45FA-A5F7-3AD9F12EA8E9
// Assembly location: C:\repos\InvoiceZVNDS\F14KInvoiceProtocolZNVLS2019OCB_2.dll

using ePlus.CommonEx.Reporting;
using ePlus.MetaData.Client;
using ePlus.MetaData.Core;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace F14KInvoiceProtocolZNVLS2019OCB
{
  public class InvoiceRating : AbstractDocumentReport, IExternalDocumentPrintForm, IExternalReport, IDocumentPrintForm
  {
    private const string CACHE_FOLDER = "Cache";
    private string connectionString;
    private string folderPath;

    private void CreateStoredProc(string connectionString)
    {
      using (StreamReader streamReader = new StreamReader(this.GetType().Assembly.GetManifestResourceStream("F14KInvoiceProtocolZNVLS2019OCB.F14KInvoiceProtocolZNVLSKF.sql"), Encoding.GetEncoding(1251)))
      {
        string[] strArray = Regex.Split(streamReader.ReadToEnd(), "^GO.*$", RegexOptions.Multiline);
        foreach (string cmdText in strArray)
        {
          if (!(cmdText == string.Empty))
          {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
              connection.Open();
              sqlCommand.ExecuteNonQuery();
            }
          }
        }
      }
    }

    private void ExtractReport()
    {
      string str = Path.Combine(this.folderPath, "Cache");
      if (!Directory.Exists(str))
        Directory.CreateDirectory(str);
      using (StreamReader streamReader = new StreamReader(this.GetType().Assembly.GetManifestResourceStream("F14KInvoiceProtocolZNVLS2019OCB.F14KInvoiceProtocolZNVLSKF.rdlc")))
      {
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine(str, "F14KInvoiceProtocolZNVLSKF.rdlc")))
          streamWriter.Write(streamReader.ReadToEnd());
      }
    }

    public override IReportForm GetReportForm(DataRowItem dataRowItem)
    {
      XmlDocument xmlDocument = new XmlDocument();
      Utils.AddNode(Utils.AddNode((XmlNode) xmlDocument, "XML"), "ID_GLOBAL", dataRowItem.Guid);
      ReportFormNew reportFormNew = new ReportFormNew();
      reportFormNew.Text = reportFormNew.ReportFormName = this.ReportName;
      reportFormNew.ReportPath = Path.Combine(Path.Combine(this.folderPath, "Cache"), "F14KInvoiceProtocolZNVLSKF.rdlc");
      reportFormNew.LoadData("REPEX_INVOICE_PROTOCOL_ZNVLS_KF", xmlDocument.InnerXml);
      reportFormNew.BindDataSource("InvoiceProtocolZNVLS_DS_Table0", 1);
      reportFormNew.BindDataSource("InvoiceProtocolZNVLS_DS_Table1", 0);
      reportFormNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      reportFormNew.Width = 29;
      return (IReportForm) reportFormNew;
    }

    public string PluginCode => "INVOICE";

    public void Execute(string connectionString, string folderPath)
    {
      this.connectionString = connectionString;
      this.folderPath = folderPath;
      this.CreateStoredProc(this.connectionString);
      this.ExtractReport();
    }

    public string GroupName => string.Empty;

    public string ReportName => "Протокол согласования цен ЖНВЛС 2019 НДС РОЗН";
  }
}
