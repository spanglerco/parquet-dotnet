#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
//using Thrift.Transport;
//using Thrift.Transport.Client;
//using Thrift.Transport.Server;
//using Thrift.Processor;


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Parquet.Thrift
{

  /// <summary>
  /// Represents a element inside a schema definition.
  ///  - if it is a group (inner node) then type is undefined and num_children is defined
  ///  - if it is a primitive type (leaf) then type is defined and num_children is undefined
  /// the nodes are listed in depth first traversal order.
  /// </summary>
  public partial class SchemaElement : TBase
  {
    private global::Parquet.Thrift.Type _type;
    private int _type_length;
    private global::Parquet.Thrift.FieldRepetitionType _repetition_type;
    private int _num_children;
    private global::Parquet.Thrift.ConvertedType _converted_type;
    private int _scale;
    private int _precision;
    private int _field_id;
    private global::Parquet.Thrift.LogicalType _logicalType;

    /// <summary>
    /// Data type for this field. Not set if the current element is a non-leaf node
    /// 
    /// <seealso cref="global::Parquet.Thrift.Type"/>
    /// </summary>
    public global::Parquet.Thrift.Type Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    /// <summary>
    /// If type is FIXED_LEN_BYTE_ARRAY, this is the byte length of the vales.
    /// Otherwise, if specified, this is the maximum bit length to store any of the values.
    /// (e.g. a low cardinality INT col could have this set to 3).  Note that this is
    /// in the schema, and therefore fixed for the entire file.
    /// </summary>
    public int Type_length
    {
      get
      {
        return _type_length;
      }
      set
      {
        __isset.type_length = true;
        this._type_length = value;
      }
    }

    /// <summary>
    /// repetition of the field. The root of the schema does not have a repetition_type.
    /// All other nodes must have one
    /// 
    /// <seealso cref="global::Parquet.Thrift.FieldRepetitionType"/>
    /// </summary>
    public global::Parquet.Thrift.FieldRepetitionType Repetition_type
    {
      get
      {
        return _repetition_type;
      }
      set
      {
        __isset.repetition_type = true;
        this._repetition_type = value;
      }
    }

    /// <summary>
    /// Name of the field in the schema
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Nested fields.  Since thrift does not support nested fields,
    /// the nesting is flattened to a single list by a depth-first traversal.
    /// The children count is used to construct the nested relationship.
    /// This field is not set when the element is a primitive type
    /// </summary>
    public int Num_children
    {
      get
      {
        return _num_children;
      }
      set
      {
        __isset.num_children = true;
        this._num_children = value;
      }
    }

    /// <summary>
    /// DEPRECATED: When the schema is the result of a conversion from another model.
    /// Used to record the original type to help with cross conversion.
    /// 
    /// This is superseded by logicalType.
    /// 
    /// <seealso cref="global::Parquet.Thrift.ConvertedType"/>
    /// </summary>
    public global::Parquet.Thrift.ConvertedType Converted_type
    {
      get
      {
        return _converted_type;
      }
      set
      {
        __isset.converted_type = true;
        this._converted_type = value;
      }
    }

    /// <summary>
    /// DEPRECATED: Used when this column contains decimal data.
    /// See the DECIMAL converted type for more details.
    /// 
    /// This is superseded by using the DecimalType annotation in logicalType.
    /// </summary>
    public int Scale
    {
      get
      {
        return _scale;
      }
      set
      {
        __isset.scale = true;
        this._scale = value;
      }
    }

    public int Precision
    {
      get
      {
        return _precision;
      }
      set
      {
        __isset.precision = true;
        this._precision = value;
      }
    }

    /// <summary>
    /// When the original schema supports field ids, this will save the
    /// original field id in the parquet schema
    /// </summary>
    public int Field_id
    {
      get
      {
        return _field_id;
      }
      set
      {
        __isset.field_id = true;
        this._field_id = value;
      }
    }

    /// <summary>
    /// The logical type of this SchemaElement
    /// 
    /// LogicalType replaces ConvertedType, but ConvertedType is still required
    /// for some logical types to ensure forward-compatibility in format v1.
    /// </summary>
    public global::Parquet.Thrift.LogicalType LogicalType
    {
      get
      {
        return _logicalType;
      }
      set
      {
        __isset.logicalType = true;
        this._logicalType = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool type;
      public bool type_length;
      public bool repetition_type;
      public bool num_children;
      public bool converted_type;
      public bool scale;
      public bool precision;
      public bool field_id;
      public bool logicalType;
    }

    public SchemaElement()
    {
    }

    public SchemaElement(string name) : this()
    {
      this.Name = name;
    }

    public SchemaElement DeepCopy()
    {
      var tmp83 = new SchemaElement();
      if(__isset.type)
      {
        tmp83.Type = this.Type;
      }
      tmp83.__isset.type = this.__isset.type;
      if(__isset.type_length)
      {
        tmp83.Type_length = this.Type_length;
      }
      tmp83.__isset.type_length = this.__isset.type_length;
      if(__isset.repetition_type)
      {
        tmp83.Repetition_type = this.Repetition_type;
      }
      tmp83.__isset.repetition_type = this.__isset.repetition_type;
      if((Name != null))
      {
        tmp83.Name = this.Name;
      }
      if(__isset.num_children)
      {
        tmp83.Num_children = this.Num_children;
      }
      tmp83.__isset.num_children = this.__isset.num_children;
      if(__isset.converted_type)
      {
        tmp83.Converted_type = this.Converted_type;
      }
      tmp83.__isset.converted_type = this.__isset.converted_type;
      if(__isset.scale)
      {
        tmp83.Scale = this.Scale;
      }
      tmp83.__isset.scale = this.__isset.scale;
      if(__isset.precision)
      {
        tmp83.Precision = this.Precision;
      }
      tmp83.__isset.precision = this.__isset.precision;
      if(__isset.field_id)
      {
        tmp83.Field_id = this.Field_id;
      }
      tmp83.__isset.field_id = this.__isset.field_id;
      if((LogicalType != null) && __isset.logicalType)
      {
        tmp83.LogicalType = (global::Parquet.Thrift.LogicalType)this.LogicalType.DeepCopy();
      }
      tmp83.__isset.logicalType = this.__isset.logicalType;
      return tmp83;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_name = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Type = (global::Parquet.Thrift.Type)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Type_length = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Repetition_type = (global::Parquet.Thrift.FieldRepetitionType)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadStringAsync(cancellationToken);
                isset_name = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                Num_children = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I32)
              {
                Converted_type = (global::Parquet.Thrift.ConvertedType)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Scale = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I32)
              {
                Precision = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I32)
              {
                Field_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Struct)
              {
                LogicalType = new global::Parquet.Thrift.LogicalType();
                await LogicalType.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_name)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp84 = new TStruct("SchemaElement");
        await oprot.WriteStructBeginAsync(tmp84, cancellationToken);
        var tmp85 = new TField();
        if(__isset.type)
        {
          tmp85.Name = "type";
          tmp85.Type = TType.I32;
          tmp85.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async((int)Type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.type_length)
        {
          tmp85.Name = "type_length";
          tmp85.Type = TType.I32;
          tmp85.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async(Type_length, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.repetition_type)
        {
          tmp85.Name = "repetition_type";
          tmp85.Type = TType.I32;
          tmp85.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async((int)Repetition_type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Name != null))
        {
          tmp85.Name = "name";
          tmp85.Type = TType.String;
          tmp85.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.num_children)
        {
          tmp85.Name = "num_children";
          tmp85.Type = TType.I32;
          tmp85.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async(Num_children, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.converted_type)
        {
          tmp85.Name = "converted_type";
          tmp85.Type = TType.I32;
          tmp85.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async((int)Converted_type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.scale)
        {
          tmp85.Name = "scale";
          tmp85.Type = TType.I32;
          tmp85.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async(Scale, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.precision)
        {
          tmp85.Name = "precision";
          tmp85.Type = TType.I32;
          tmp85.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async(Precision, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.field_id)
        {
          tmp85.Name = "field_id";
          tmp85.Type = TType.I32;
          tmp85.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await oprot.WriteI32Async(Field_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((LogicalType != null) && __isset.logicalType)
        {
          tmp85.Name = "logicalType";
          tmp85.Type = TType.Struct;
          tmp85.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp85, cancellationToken);
          await LogicalType.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is SchemaElement other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.type == other.__isset.type) && ((!__isset.type) || (global::System.Object.Equals(Type, other.Type))))
        && ((__isset.type_length == other.__isset.type_length) && ((!__isset.type_length) || (global::System.Object.Equals(Type_length, other.Type_length))))
        && ((__isset.repetition_type == other.__isset.repetition_type) && ((!__isset.repetition_type) || (global::System.Object.Equals(Repetition_type, other.Repetition_type))))
        && global::System.Object.Equals(Name, other.Name)
        && ((__isset.num_children == other.__isset.num_children) && ((!__isset.num_children) || (global::System.Object.Equals(Num_children, other.Num_children))))
        && ((__isset.converted_type == other.__isset.converted_type) && ((!__isset.converted_type) || (global::System.Object.Equals(Converted_type, other.Converted_type))))
        && ((__isset.scale == other.__isset.scale) && ((!__isset.scale) || (global::System.Object.Equals(Scale, other.Scale))))
        && ((__isset.precision == other.__isset.precision) && ((!__isset.precision) || (global::System.Object.Equals(Precision, other.Precision))))
        && ((__isset.field_id == other.__isset.field_id) && ((!__isset.field_id) || (global::System.Object.Equals(Field_id, other.Field_id))))
        && ((__isset.logicalType == other.__isset.logicalType) && ((!__isset.logicalType) || (global::System.Object.Equals(LogicalType, other.LogicalType))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.type)
        {
          hashcode = (hashcode * 397) + Type.GetHashCode();
        }
        if(__isset.type_length)
        {
          hashcode = (hashcode * 397) + Type_length.GetHashCode();
        }
        if(__isset.repetition_type)
        {
          hashcode = (hashcode * 397) + Repetition_type.GetHashCode();
        }
        if((Name != null))
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if(__isset.num_children)
        {
          hashcode = (hashcode * 397) + Num_children.GetHashCode();
        }
        if(__isset.converted_type)
        {
          hashcode = (hashcode * 397) + Converted_type.GetHashCode();
        }
        if(__isset.scale)
        {
          hashcode = (hashcode * 397) + Scale.GetHashCode();
        }
        if(__isset.precision)
        {
          hashcode = (hashcode * 397) + Precision.GetHashCode();
        }
        if(__isset.field_id)
        {
          hashcode = (hashcode * 397) + Field_id.GetHashCode();
        }
        if((LogicalType != null) && __isset.logicalType)
        {
          hashcode = (hashcode * 397) + LogicalType.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp86 = new StringBuilder("SchemaElement(");
      int tmp87 = 0;
      if(__isset.type)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Type: ");
        Type.ToString(tmp86);
      }
      if(__isset.type_length)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Type_length: ");
        Type_length.ToString(tmp86);
      }
      if(__isset.repetition_type)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Repetition_type: ");
        Repetition_type.ToString(tmp86);
      }
      if((Name != null))
      {
        if(0 < tmp87) { tmp86.Append(", "); }
        tmp86.Append("Name: ");
        Name.ToString(tmp86);
      }
      if(__isset.num_children)
      {
        tmp86.Append(", Num_children: ");
        Num_children.ToString(tmp86);
      }
      if(__isset.converted_type)
      {
        tmp86.Append(", Converted_type: ");
        Converted_type.ToString(tmp86);
      }
      if(__isset.scale)
      {
        tmp86.Append(", Scale: ");
        Scale.ToString(tmp86);
      }
      if(__isset.precision)
      {
        tmp86.Append(", Precision: ");
        Precision.ToString(tmp86);
      }
      if(__isset.field_id)
      {
        tmp86.Append(", Field_id: ");
        Field_id.ToString(tmp86);
      }
      if((LogicalType != null) && __isset.logicalType)
      {
        tmp86.Append(", LogicalType: ");
        LogicalType.ToString(tmp86);
      }
      tmp86.Append(')');
      return tmp86.ToString();
    }
  }

}
