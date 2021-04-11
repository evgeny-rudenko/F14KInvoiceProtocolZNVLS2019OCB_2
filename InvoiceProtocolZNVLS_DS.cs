// Decompiled with JetBrains decompiler
// Type: F14KInvoiceProtocolZNVLS2019OCB.InvoiceProtocolZNVLS_DS
// Assembly: F14KInvoiceProtocolZNVLS2019OCB_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 30686E9C-3056-45FA-A5F7-3AD9F12EA8E9
// Assembly location: C:\repos\InvoiceZVNDS\F14KInvoiceProtocolZNVLS2019OCB_2.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace F14KInvoiceProtocolZNVLS2019OCB
{
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [HelpKeyword("vs.data.DataSet")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlRoot("InvoiceProtocolZNVLS_DS")]
  [Serializable]
  public class InvoiceProtocolZNVLS_DS : DataSet
  {
    private InvoiceProtocolZNVLS_DS.Table0DataTable tableTable0;
    private InvoiceProtocolZNVLS_DS.Table1DataTable tableTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public InvoiceProtocolZNVLS_DS()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected InvoiceProtocolZNVLS_DS(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (Table0)] != null)
            base.Tables.Add((DataTable) new InvoiceProtocolZNVLS_DS.Table0DataTable(dataSet.Tables[nameof (Table0)]));
          if (dataSet.Tables[nameof (Table1)] != null)
            base.Tables.Add((DataTable) new InvoiceProtocolZNVLS_DS.Table1DataTable(dataSet.Tables[nameof (Table1)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public InvoiceProtocolZNVLS_DS.Table0DataTable Table0 => this.tableTable0;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoiceProtocolZNVLS_DS.Table1DataTable Table1 => this.tableTable1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataSet Clone()
    {
      InvoiceProtocolZNVLS_DS invoiceProtocolZnvlsDs = (InvoiceProtocolZNVLS_DS) base.Clone();
      invoiceProtocolZnvlsDs.InitVars();
      invoiceProtocolZnvlsDs.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) invoiceProtocolZnvlsDs;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Table0"] != null)
          base.Tables.Add((DataTable) new InvoiceProtocolZNVLS_DS.Table0DataTable(dataSet.Tables["Table0"]));
        if (dataSet.Tables["Table1"] != null)
          base.Tables.Add((DataTable) new InvoiceProtocolZNVLS_DS.Table1DataTable(dataSet.Tables["Table1"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableTable0 = (InvoiceProtocolZNVLS_DS.Table0DataTable) base.Tables["Table0"];
      if (initTable && this.tableTable0 != null)
        this.tableTable0.InitVars();
      this.tableTable1 = (InvoiceProtocolZNVLS_DS.Table1DataTable) base.Tables["Table1"];
      if (!initTable || this.tableTable1 == null)
        return;
      this.tableTable1.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (InvoiceProtocolZNVLS_DS);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/InvoiceProtocolZNVLS_DS.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTable0 = new InvoiceProtocolZNVLS_DS.Table0DataTable();
      base.Tables.Add((DataTable) this.tableTable0);
      this.tableTable1 = new InvoiceProtocolZNVLS_DS.Table1DataTable();
      base.Tables.Add((DataTable) this.tableTable1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeTable0() => false;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private bool ShouldSerializeTable1() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      InvoiceProtocolZNVLS_DS invoiceProtocolZnvlsDs = new InvoiceProtocolZNVLS_DS();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = invoiceProtocolZnvlsDs.Namespace
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = invoiceProtocolZnvlsDs.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return schemaComplexType;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return schemaComplexType;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Table0RowChangeEventHandler(
      object sender,
      InvoiceProtocolZNVLS_DS.Table0RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Table1RowChangeEventHandler(
      object sender,
      InvoiceProtocolZNVLS_DS.Table1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Table0DataTable : TypedTableBase<InvoiceProtocolZNVLS_DS.Table0Row>
    {
      private DataColumn columnGOODS_NAME;
      private DataColumn columnSERIES_NAME;
      private DataColumn columnPRODUCER_NAME;
      private DataColumn columnREGISTER_PRICE;
      private DataColumn columnPRICE_PROD;
      private DataColumn columnSUP_ADPRICE;
      private DataColumn columnSUM_ADPRICE;
      private DataColumn columnPRICE_SUP;
      private DataColumn columnSUM_ADPRICE_SAL;
      private DataColumn columnSUP_NUM2;
      private DataColumn columnSUP_ADPRICE2;
      private DataColumn columnSUM_ADPRICE2;
      private DataColumn columnPRICE_SUP2;
      private DataColumn columnSUP_NUM3;
      private DataColumn columnSUP_ADPRICE3;
      private DataColumn columnSUM_ADPRICE3;
      private DataColumn columnPRICE_SUP3;
      private DataColumn columnID;
      private DataColumn columnRETAIL_PRICE;
      private DataColumn columnRETAIL_PRICE_VAT;
      private DataColumn columnNUM;
      private DataColumn columnMNN;
      private DataColumn columnPRICE_SUP2_VAT;
      private DataColumn columnPRICE_SUP3_VAT;
      private DataColumn columnPRICE_SUP_VAT;
      private DataColumn columnSUP_ADPRICE_SAL;
      private DataColumn columnSUM_SUP_ADPRICE;
      private DataColumn columnSUM_SUM_ADPRICE;
      private DataColumn columnPRODUCER_RELEASE_DATE;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public Table0DataTable()
      {
        this.TableName = "Table0";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal Table0DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected Table0DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
        => this.InitVars();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn GOODS_NAMEColumn => this.columnGOODS_NAME;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn SERIES_NAMEColumn => this.columnSERIES_NAME;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn PRODUCER_NAMEColumn => this.columnPRODUCER_NAME;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn REGISTER_PRICEColumn => this.columnREGISTER_PRICE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn PRICE_PRODColumn => this.columnPRICE_PROD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUP_ADPRICEColumn => this.columnSUP_ADPRICE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUM_ADPRICEColumn => this.columnSUM_ADPRICE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn PRICE_SUPColumn => this.columnPRICE_SUP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUM_ADPRICE_SALColumn => this.columnSUM_ADPRICE_SAL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUP_NUM2Column => this.columnSUP_NUM2;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn SUP_ADPRICE2Column => this.columnSUP_ADPRICE2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUM_ADPRICE2Column => this.columnSUM_ADPRICE2;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn PRICE_SUP2Column => this.columnPRICE_SUP2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUP_NUM3Column => this.columnSUP_NUM3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUP_ADPRICE3Column => this.columnSUP_ADPRICE3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUM_ADPRICE3Column => this.columnSUM_ADPRICE3;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn PRICE_SUP3Column => this.columnPRICE_SUP3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn RETAIL_PRICEColumn => this.columnRETAIL_PRICE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn RETAIL_PRICE_VATColumn => this.columnRETAIL_PRICE_VAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NUMColumn => this.columnNUM;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn MNNColumn => this.columnMNN;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn PRICE_SUP2_VATColumn => this.columnPRICE_SUP2_VAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn PRICE_SUP3_VATColumn => this.columnPRICE_SUP3_VAT;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn PRICE_SUP_VATColumn => this.columnPRICE_SUP_VAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUP_ADPRICE_SALColumn => this.columnSUP_ADPRICE_SAL;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn SUM_SUP_ADPRICEColumn => this.columnSUM_SUP_ADPRICE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SUM_SUM_ADPRICEColumn => this.columnSUM_SUM_ADPRICE;

      [DebuggerNonUserCode]
      [Browsable(false)]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count => this.Rows.Count;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public InvoiceProtocolZNVLS_DS.Table0Row this[int index] => (InvoiceProtocolZNVLS_DS.Table0Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddTable0Row(InvoiceProtocolZNVLS_DS.Table0Row row) => this.Rows.Add((DataRow) row);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public InvoiceProtocolZNVLS_DS.Table0Row AddTable0Row(
        string GOODS_NAME,
        string SERIES_NAME,
        string PRODUCER_NAME,
        string REGISTER_PRICE,
        string PRICE_PROD,
        string SUP_ADPRICE,
        string SUM_ADPRICE,
        string PRICE_SUP,
        string SUM_ADPRICE_SAL,
        string SUP_NUM2,
        string SUP_ADPRICE2,
        string SUM_ADPRICE2,
        string PRICE_SUP2,
        string SUP_NUM3,
        string SUP_ADPRICE3,
        string SUM_ADPRICE3,
        string PRICE_SUP3,
        string ID,
        string RETAIL_PRICE,
        string RETAIL_PRICE_VAT,
        string NUM,
        string MNN,
        string PRICE_SUP2_VAT,
        string PRICE_SUP3_VAT,
        string PRICE_SUP_VAT,
        string SUP_ADPRICE_SAL,
        string SUM_SUP_ADPRICE,
        string SUM_SUM_ADPRICE,
        string PRODUCER_RELEASE_DATE)
      {
        InvoiceProtocolZNVLS_DS.Table0Row table0Row = (InvoiceProtocolZNVLS_DS.Table0Row) this.NewRow();
        object[] objArray = new object[29]
        {
          (object) GOODS_NAME,
          (object) SERIES_NAME,
          (object) PRODUCER_NAME,
          (object) REGISTER_PRICE,
          (object) PRICE_PROD,
          (object) SUP_ADPRICE,
          (object) SUM_ADPRICE,
          (object) PRICE_SUP,
          (object) SUM_ADPRICE_SAL,
          (object) SUP_NUM2,
          (object) SUP_ADPRICE2,
          (object) SUM_ADPRICE2,
          (object) PRICE_SUP2,
          (object) SUP_NUM3,
          (object) SUP_ADPRICE3,
          (object) SUM_ADPRICE3,
          (object) PRICE_SUP3,
          (object) ID,
          (object) RETAIL_PRICE,
          (object) RETAIL_PRICE_VAT,
          (object) NUM,
          (object) MNN,
          (object) PRICE_SUP2_VAT,
          (object) PRICE_SUP3_VAT,
          (object) PRICE_SUP_VAT,
          (object) SUP_ADPRICE_SAL,
          (object) SUM_SUP_ADPRICE,
          (object) SUM_SUM_ADPRICE,
          (object) PRODUCER_RELEASE_DATE
        };
        table0Row.ItemArray = objArray;
        this.Rows.Add((DataRow) table0Row);
        return table0Row;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        InvoiceProtocolZNVLS_DS.Table0DataTable table0DataTable = (InvoiceProtocolZNVLS_DS.Table0DataTable) base.Clone();
        table0DataTable.InitVars();
        return (DataTable) table0DataTable;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new InvoiceProtocolZNVLS_DS.Table0DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnGOODS_NAME = this.Columns["GOODS_NAME"];
        this.columnSERIES_NAME = this.Columns["SERIES_NAME"];
        this.columnPRODUCER_NAME = this.Columns["PRODUCER_NAME"];
        this.columnREGISTER_PRICE = this.Columns["REGISTER_PRICE"];
        this.columnPRICE_PROD = this.Columns["PRICE_PROD"];
        this.columnSUP_ADPRICE = this.Columns["SUP_ADPRICE"];
        this.columnSUM_ADPRICE = this.Columns["SUM_ADPRICE"];
        this.columnPRICE_SUP = this.Columns["PRICE_SUP"];
        this.columnSUM_ADPRICE_SAL = this.Columns["SUM_ADPRICE_SAL"];
        this.columnSUP_NUM2 = this.Columns["SUP_NUM2"];
        this.columnSUP_ADPRICE2 = this.Columns["SUP_ADPRICE2"];
        this.columnSUM_ADPRICE2 = this.Columns["SUM_ADPRICE2"];
        this.columnPRICE_SUP2 = this.Columns["PRICE_SUP2"];
        this.columnSUP_NUM3 = this.Columns["SUP_NUM3"];
        this.columnSUP_ADPRICE3 = this.Columns["SUP_ADPRICE3"];
        this.columnSUM_ADPRICE3 = this.Columns["SUM_ADPRICE3"];
        this.columnPRICE_SUP3 = this.Columns["PRICE_SUP3"];
        this.columnID = this.Columns["ID"];
        this.columnRETAIL_PRICE = this.Columns["RETAIL_PRICE"];
        this.columnRETAIL_PRICE_VAT = this.Columns["RETAIL_PRICE_VAT"];
        this.columnNUM = this.Columns["NUM"];
        this.columnMNN = this.Columns["MNN"];
        this.columnPRICE_SUP2_VAT = this.Columns["PRICE_SUP2_VAT"];
        this.columnPRICE_SUP3_VAT = this.Columns["PRICE_SUP3_VAT"];
        this.columnPRICE_SUP_VAT = this.Columns["PRICE_SUP_VAT"];
        this.columnSUP_ADPRICE_SAL = this.Columns["SUP_ADPRICE_SAL"];
        this.columnSUM_SUP_ADPRICE = this.Columns["SUM_SUP_ADPRICE"];
        this.columnSUM_SUM_ADPRICE = this.Columns["SUM_SUM_ADPRICE"];
        this.columnPRODUCER_RELEASE_DATE = this.Columns["PRODUCER_RELEASE_DATE"];
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGOODS_NAME = new DataColumn("GOODS_NAME", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOODS_NAME);
        this.columnSERIES_NAME = new DataColumn("SERIES_NAME", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSERIES_NAME);
        this.columnPRODUCER_NAME = new DataColumn("PRODUCER_NAME", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRODUCER_NAME);
        this.columnREGISTER_PRICE = new DataColumn("REGISTER_PRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnREGISTER_PRICE);
        this.columnPRICE_PROD = new DataColumn("PRICE_PROD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_PROD);
        this.columnSUP_ADPRICE = new DataColumn("SUP_ADPRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_ADPRICE);
        this.columnSUM_ADPRICE = new DataColumn("SUM_ADPRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_ADPRICE);
        this.columnPRICE_SUP = new DataColumn("PRICE_SUP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP);
        this.columnSUM_ADPRICE_SAL = new DataColumn("SUM_ADPRICE_SAL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_ADPRICE_SAL);
        this.columnSUP_NUM2 = new DataColumn("SUP_NUM2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_NUM2);
        this.columnSUP_ADPRICE2 = new DataColumn("SUP_ADPRICE2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_ADPRICE2);
        this.columnSUM_ADPRICE2 = new DataColumn("SUM_ADPRICE2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_ADPRICE2);
        this.columnPRICE_SUP2 = new DataColumn("PRICE_SUP2", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP2);
        this.columnSUP_NUM3 = new DataColumn("SUP_NUM3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_NUM3);
        this.columnSUP_ADPRICE3 = new DataColumn("SUP_ADPRICE3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_ADPRICE3);
        this.columnSUM_ADPRICE3 = new DataColumn("SUM_ADPRICE3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_ADPRICE3);
        this.columnPRICE_SUP3 = new DataColumn("PRICE_SUP3", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP3);
        this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnRETAIL_PRICE = new DataColumn("RETAIL_PRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRETAIL_PRICE);
        this.columnRETAIL_PRICE_VAT = new DataColumn("RETAIL_PRICE_VAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRETAIL_PRICE_VAT);
        this.columnNUM = new DataColumn("NUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnNUM);
        this.columnMNN = new DataColumn("MNN", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMNN);
        this.columnPRICE_SUP2_VAT = new DataColumn("PRICE_SUP2_VAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP2_VAT);
        this.columnPRICE_SUP3_VAT = new DataColumn("PRICE_SUP3_VAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP3_VAT);
        this.columnPRICE_SUP_VAT = new DataColumn("PRICE_SUP_VAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPRICE_SUP_VAT);
        this.columnSUP_ADPRICE_SAL = new DataColumn("SUP_ADPRICE_SAL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUP_ADPRICE_SAL);
        this.columnSUM_SUP_ADPRICE = new DataColumn("SUM_SUP_ADPRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_SUP_ADPRICE);
        this.columnSUM_SUM_ADPRICE = new DataColumn("SUM_SUM_ADPRICE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSUM_SUM_ADPRICE);
        this.columnPRODUCER_RELEASE_DATE = new DataColumn("PRODUCER_RELEASE_DATE", typeof(string), (string)null, MappingType.Element);
                this.Columns.Add(this.columnPRODUCER_RELEASE_DATE);

                //PRODUCER_RELEASE_DATE

            }

            [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public InvoiceProtocolZNVLS_DS.Table0Row NewTable0Row() => (InvoiceProtocolZNVLS_DS.Table0Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new InvoiceProtocolZNVLS_DS.Table0Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType() => typeof (InvoiceProtocolZNVLS_DS.Table0Row);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Table0RowChanged == null)
          return;
        this.Table0RowChanged((object) this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Table0RowChanging == null)
          return;
        this.Table0RowChanging((object) this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Table0RowDeleted == null)
          return;
        this.Table0RowDeleted((object) this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Table0RowDeleting == null)
          return;
        this.Table0RowDeleting((object) this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveTable0Row(InvoiceProtocolZNVLS_DS.Table0Row row) => this.Rows.Remove((DataRow) row);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        InvoiceProtocolZNVLS_DS invoiceProtocolZnvlsDs = new InvoiceProtocolZNVLS_DS();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = invoiceProtocolZnvlsDs.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Table0DataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = invoiceProtocolZnvlsDs.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Table1DataTable : TypedTableBase<InvoiceProtocolZNVLS_DS.Table1Row>
    {
      private DataColumn columnFR_NAME;
      private DataColumn columnTO_NAME;
      private DataColumn columnDIR;
      private DataColumn columnINCOMING_BILL_NUMBER;
      private DataColumn columnINCOMING_BILL_DATE;
      private DataColumn columnMNEMOCODE;
      private DataColumn columnDOCUMENT_DATE;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public Table1DataTable()
      {
        this.TableName = "Table1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal Table1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected Table1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
        => this.InitVars();

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn FR_NAMEColumn => this.columnFR_NAME;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TO_NAMEColumn => this.columnTO_NAME;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn DIRColumn => this.columnDIR;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn INCOMING_BILL_NUMBERColumn => this.columnINCOMING_BILL_NUMBER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn INCOMING_BILL_DATEColumn => this.columnINCOMING_BILL_DATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MNEMOCODEColumn => this.columnMNEMOCODE;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn DOCUMENT_DATEColumn => this.columnDOCUMENT_DATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public InvoiceProtocolZNVLS_DS.Table1Row this[int index] => (InvoiceProtocolZNVLS_DS.Table1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddTable1Row(InvoiceProtocolZNVLS_DS.Table1Row row) => this.Rows.Add((DataRow) row);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public InvoiceProtocolZNVLS_DS.Table1Row AddTable1Row(
        string FR_NAME,
        string TO_NAME,
        string DIR,
        string INCOMING_BILL_NUMBER,
        string INCOMING_BILL_DATE,
        string MNEMOCODE,
        string DOCUMENT_DATE)
      {
        InvoiceProtocolZNVLS_DS.Table1Row table1Row = (InvoiceProtocolZNVLS_DS.Table1Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) FR_NAME,
          (object) TO_NAME,
          (object) DIR,
          (object) INCOMING_BILL_NUMBER,
          (object) INCOMING_BILL_DATE,
          (object) MNEMOCODE,
          (object) DOCUMENT_DATE
        };
        table1Row.ItemArray = objArray;
        this.Rows.Add((DataRow) table1Row);
        return table1Row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        InvoiceProtocolZNVLS_DS.Table1DataTable table1DataTable = (InvoiceProtocolZNVLS_DS.Table1DataTable) base.Clone();
        table1DataTable.InitVars();
        return (DataTable) table1DataTable;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new InvoiceProtocolZNVLS_DS.Table1DataTable();

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnFR_NAME = this.Columns["FR_NAME"];
        this.columnTO_NAME = this.Columns["TO_NAME"];
        this.columnDIR = this.Columns["DIR"];
        this.columnINCOMING_BILL_NUMBER = this.Columns["INCOMING_BILL_NUMBER"];
        this.columnINCOMING_BILL_DATE = this.Columns["INCOMING_BILL_DATE"];
        this.columnMNEMOCODE = this.Columns["MNEMOCODE"];
        this.columnDOCUMENT_DATE = this.Columns["DOCUMENT_DATE"];
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnFR_NAME = new DataColumn("FR_NAME", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFR_NAME);
        this.columnTO_NAME = new DataColumn("TO_NAME", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTO_NAME);
        this.columnDIR = new DataColumn("DIR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDIR);
        this.columnINCOMING_BILL_NUMBER = new DataColumn("INCOMING_BILL_NUMBER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnINCOMING_BILL_NUMBER);
        this.columnINCOMING_BILL_DATE = new DataColumn("INCOMING_BILL_DATE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnINCOMING_BILL_DATE);
        this.columnMNEMOCODE = new DataColumn("MNEMOCODE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMNEMOCODE);
        this.columnDOCUMENT_DATE = new DataColumn("DOCUMENT_DATE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDOCUMENT_DATE);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public InvoiceProtocolZNVLS_DS.Table1Row NewTable1Row() => (InvoiceProtocolZNVLS_DS.Table1Row) this.NewRow();

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new InvoiceProtocolZNVLS_DS.Table1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType() => typeof (InvoiceProtocolZNVLS_DS.Table1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Table1RowChanged == null)
          return;
        this.Table1RowChanged((object) this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Table1RowChanging == null)
          return;
        this.Table1RowChanging((object) this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Table1RowDeleted == null)
          return;
        this.Table1RowDeleted((object) this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Table1RowDeleting == null)
          return;
        this.Table1RowDeleting((object) this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveTable1Row(InvoiceProtocolZNVLS_DS.Table1Row row) => this.Rows.Remove((DataRow) row);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        InvoiceProtocolZNVLS_DS invoiceProtocolZnvlsDs = new InvoiceProtocolZNVLS_DS();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = invoiceProtocolZnvlsDs.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Table1DataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = invoiceProtocolZnvlsDs.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    public class Table0Row : DataRow
    {
      private InvoiceProtocolZNVLS_DS.Table0DataTable tableTable0;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal Table0Row(DataRowBuilder rb)
        : base(rb)
        => this.tableTable0 = (InvoiceProtocolZNVLS_DS.Table0DataTable) this.Table;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string GOODS_NAME
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.GOODS_NAMEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'GOODS_NAME' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.GOODS_NAMEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SERIES_NAME
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SERIES_NAMEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SERIES_NAME' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SERIES_NAMEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string PRODUCER_NAME
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRODUCER_NAMEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRODUCER_NAME' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRODUCER_NAMEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string REGISTER_PRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.REGISTER_PRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'REGISTER_PRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.REGISTER_PRICEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string PRICE_PROD
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_PRODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_PROD' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_PRODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUP_ADPRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_ADPRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_ADPRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_ADPRICEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUM_ADPRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_ADPRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_ADPRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_ADPRICEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string PRICE_SUP
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUPColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SUM_ADPRICE_SAL
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_ADPRICE_SALColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_ADPRICE_SAL' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_ADPRICE_SALColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUP_NUM2
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_NUM2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_NUM2' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_NUM2Column] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SUP_ADPRICE2
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_ADPRICE2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_ADPRICE2' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_ADPRICE2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUM_ADPRICE2
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_ADPRICE2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_ADPRICE2' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_ADPRICE2Column] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string PRICE_SUP2
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUP2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP2' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUP2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUP_NUM3
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_NUM3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_NUM3' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_NUM3Column] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SUP_ADPRICE3
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_ADPRICE3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_ADPRICE3' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_ADPRICE3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUM_ADPRICE3
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_ADPRICE3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_ADPRICE3' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_ADPRICE3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string PRICE_SUP3
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUP3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP3' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUP3Column] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'ID' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.IDColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string RETAIL_PRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.RETAIL_PRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'RETAIL_PRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.RETAIL_PRICEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string RETAIL_PRICE_VAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.RETAIL_PRICE_VATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'RETAIL_PRICE_VAT' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.RETAIL_PRICE_VATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string NUM
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.NUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'NUM' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.NUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MNN
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.MNNColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'MNN' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.MNNColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string PRICE_SUP2_VAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUP2_VATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP2_VAT' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUP2_VATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string PRICE_SUP3_VAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUP3_VATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP3_VAT' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUP3_VATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string PRICE_SUP_VAT
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.PRICE_SUP_VATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'PRICE_SUP_VAT' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.PRICE_SUP_VATColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SUP_ADPRICE_SAL
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUP_ADPRICE_SALColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUP_ADPRICE_SAL' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUP_ADPRICE_SALColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SUM_SUP_ADPRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_SUP_ADPRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_SUP_ADPRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_SUP_ADPRICEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SUM_SUM_ADPRICE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable0.SUM_SUM_ADPRICEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'SUM_SUM_ADPRICE' в таблице 'Table0' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable0.SUM_SUM_ADPRICEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsGOODS_NAMENull() => this.IsNull(this.tableTable0.GOODS_NAMEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetGOODS_NAMENull() => this[this.tableTable0.GOODS_NAMEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSERIES_NAMENull() => this.IsNull(this.tableTable0.SERIES_NAMEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSERIES_NAMENull() => this[this.tableTable0.SERIES_NAMEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsPRODUCER_NAMENull() => this.IsNull(this.tableTable0.PRODUCER_NAMEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetPRODUCER_NAMENull() => this[this.tableTable0.PRODUCER_NAMEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsREGISTER_PRICENull() => this.IsNull(this.tableTable0.REGISTER_PRICEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetREGISTER_PRICENull() => this[this.tableTable0.REGISTER_PRICEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsPRICE_PRODNull() => this.IsNull(this.tableTable0.PRICE_PRODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetPRICE_PRODNull() => this[this.tableTable0.PRICE_PRODColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUP_ADPRICENull() => this.IsNull(this.tableTable0.SUP_ADPRICEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUP_ADPRICENull() => this[this.tableTable0.SUP_ADPRICEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUM_ADPRICENull() => this.IsNull(this.tableTable0.SUM_ADPRICEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUM_ADPRICENull() => this[this.tableTable0.SUM_ADPRICEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsPRICE_SUPNull() => this.IsNull(this.tableTable0.PRICE_SUPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetPRICE_SUPNull() => this[this.tableTable0.PRICE_SUPColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUM_ADPRICE_SALNull() => this.IsNull(this.tableTable0.SUM_ADPRICE_SALColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUM_ADPRICE_SALNull() => this[this.tableTable0.SUM_ADPRICE_SALColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUP_NUM2Null() => this.IsNull(this.tableTable0.SUP_NUM2Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUP_NUM2Null() => this[this.tableTable0.SUP_NUM2Column] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUP_ADPRICE2Null() => this.IsNull(this.tableTable0.SUP_ADPRICE2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSUP_ADPRICE2Null() => this[this.tableTable0.SUP_ADPRICE2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUM_ADPRICE2Null() => this.IsNull(this.tableTable0.SUM_ADPRICE2Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUM_ADPRICE2Null() => this[this.tableTable0.SUM_ADPRICE2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsPRICE_SUP2Null() => this.IsNull(this.tableTable0.PRICE_SUP2Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetPRICE_SUP2Null() => this[this.tableTable0.PRICE_SUP2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUP_NUM3Null() => this.IsNull(this.tableTable0.SUP_NUM3Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUP_NUM3Null() => this[this.tableTable0.SUP_NUM3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUP_ADPRICE3Null() => this.IsNull(this.tableTable0.SUP_ADPRICE3Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUP_ADPRICE3Null() => this[this.tableTable0.SUP_ADPRICE3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSUM_ADPRICE3Null() => this.IsNull(this.tableTable0.SUM_ADPRICE3Column);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUM_ADPRICE3Null() => this[this.tableTable0.SUM_ADPRICE3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsPRICE_SUP3Null() => this.IsNull(this.tableTable0.PRICE_SUP3Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetPRICE_SUP3Null() => this[this.tableTable0.PRICE_SUP3Column] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsIDNull() => this.IsNull(this.tableTable0.IDColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetIDNull() => this[this.tableTable0.IDColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsRETAIL_PRICENull() => this.IsNull(this.tableTable0.RETAIL_PRICEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetRETAIL_PRICENull() => this[this.tableTable0.RETAIL_PRICEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsRETAIL_PRICE_VATNull() => this.IsNull(this.tableTable0.RETAIL_PRICE_VATColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetRETAIL_PRICE_VATNull() => this[this.tableTable0.RETAIL_PRICE_VATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsNUMNull() => this.IsNull(this.tableTable0.NUMColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetNUMNull() => this[this.tableTable0.NUMColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsMNNNull() => this.IsNull(this.tableTable0.MNNColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetMNNNull() => this[this.tableTable0.MNNColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsPRICE_SUP2_VATNull() => this.IsNull(this.tableTable0.PRICE_SUP2_VATColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetPRICE_SUP2_VATNull() => this[this.tableTable0.PRICE_SUP2_VATColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsPRICE_SUP3_VATNull() => this.IsNull(this.tableTable0.PRICE_SUP3_VATColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetPRICE_SUP3_VATNull() => this[this.tableTable0.PRICE_SUP3_VATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsPRICE_SUP_VATNull() => this.IsNull(this.tableTable0.PRICE_SUP_VATColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetPRICE_SUP_VATNull() => this[this.tableTable0.PRICE_SUP_VATColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUP_ADPRICE_SALNull() => this.IsNull(this.tableTable0.SUP_ADPRICE_SALColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUP_ADPRICE_SALNull() => this[this.tableTable0.SUP_ADPRICE_SALColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUM_SUP_ADPRICENull() => this.IsNull(this.tableTable0.SUM_SUP_ADPRICEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetSUM_SUP_ADPRICENull() => this[this.tableTable0.SUM_SUP_ADPRICEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsSUM_SUM_ADPRICENull() => this.IsNull(this.tableTable0.SUM_SUM_ADPRICEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSUM_SUM_ADPRICENull() => this[this.tableTable0.SUM_SUM_ADPRICEColumn] = Convert.DBNull;
    }

    public class Table1Row : DataRow
    {
      private InvoiceProtocolZNVLS_DS.Table1DataTable tableTable1;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal Table1Row(DataRowBuilder rb)
        : base(rb)
        => this.tableTable1 = (InvoiceProtocolZNVLS_DS.Table1DataTable) this.Table;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string FR_NAME
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.FR_NAMEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'FR_NAME' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.FR_NAMEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string TO_NAME
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.TO_NAMEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'TO_NAME' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.TO_NAMEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string DIR
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.DIRColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'DIR' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.DIRColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string INCOMING_BILL_NUMBER
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.INCOMING_BILL_NUMBERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'INCOMING_BILL_NUMBER' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.INCOMING_BILL_NUMBERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string INCOMING_BILL_DATE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.INCOMING_BILL_DATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'INCOMING_BILL_DATE' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.INCOMING_BILL_DATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MNEMOCODE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.MNEMOCODEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'MNEMOCODE' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.MNEMOCODEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string DOCUMENT_DATE
      {
        get
        {
          try
          {
            return (string) this[this.tableTable1.DOCUMENT_DATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Значение для столбца 'DOCUMENT_DATE' в таблице 'Table1' равно DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTable1.DOCUMENT_DATEColumn] = (object) value;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsFR_NAMENull() => this.IsNull(this.tableTable1.FR_NAMEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetFR_NAMENull() => this[this.tableTable1.FR_NAMEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTO_NAMENull() => this.IsNull(this.tableTable1.TO_NAMEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetTO_NAMENull() => this[this.tableTable1.TO_NAMEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsDIRNull() => this.IsNull(this.tableTable1.DIRColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetDIRNull() => this[this.tableTable1.DIRColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsINCOMING_BILL_NUMBERNull() => this.IsNull(this.tableTable1.INCOMING_BILL_NUMBERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetINCOMING_BILL_NUMBERNull() => this[this.tableTable1.INCOMING_BILL_NUMBERColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsINCOMING_BILL_DATENull() => this.IsNull(this.tableTable1.INCOMING_BILL_DATEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetINCOMING_BILL_DATENull() => this[this.tableTable1.INCOMING_BILL_DATEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsMNEMOCODENull() => this.IsNull(this.tableTable1.MNEMOCODEColumn);

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetMNEMOCODENull() => this[this.tableTable1.MNEMOCODEColumn] = Convert.DBNull;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsDOCUMENT_DATENull() => this.IsNull(this.tableTable1.DOCUMENT_DATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDOCUMENT_DATENull() => this[this.tableTable1.DOCUMENT_DATEColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class Table0RowChangeEvent : EventArgs
    {
      private InvoiceProtocolZNVLS_DS.Table0Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public Table0RowChangeEvent(InvoiceProtocolZNVLS_DS.Table0Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public InvoiceProtocolZNVLS_DS.Table0Row Row => this.eventRow;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class Table1RowChangeEvent : EventArgs
    {
      private InvoiceProtocolZNVLS_DS.Table1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public Table1RowChangeEvent(InvoiceProtocolZNVLS_DS.Table1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public InvoiceProtocolZNVLS_DS.Table1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
