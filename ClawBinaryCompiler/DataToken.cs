﻿using System;
using System.Text;

namespace ClawBinaryCompiler
{
	public class DataToken : ClawToken
	{
		public byte[] Bytes { get; private set; }

		public DataType DataType { get; private set; }

		public bool IsArray { get; private set; }

		public DataToken(sbyte Value)
		{
			Bytes = new byte[] { unchecked ((byte)Value) };
			DataType = DataType.Int8;
			IsArray = false;
		}

		public DataToken(byte Value)
		{
			Bytes = new byte[] { Value };
			DataType = DataType.UInt8;
			IsArray = false;
		}

		public DataToken(short Value)
		{
			Bytes = BitConverter.GetBytes(Value);
			DataType = DataType.Int16;
			IsArray = false;
		}

		public DataToken(ushort Value)
		{
			Bytes = BitConverter.GetBytes(Value);
			DataType = DataType.UInt16;
			IsArray = false;
		}

		public DataToken(int Value)
		{
			Bytes = BitConverter.GetBytes(Value);
			DataType = DataType.Int32;
			IsArray = false;
		}

		public DataToken(uint Value)
		{
			Bytes = BitConverter.GetBytes(Value);
			DataType = DataType.UInt32;
			IsArray = false;
		}

		public DataToken(float Value)
		{
			Bytes = BitConverter.GetBytes(Value);
			DataType = DataType.Float;
			IsArray = false;
		}

		public DataToken(string String)
		{
			Bytes = Encoding.ASCII.GetBytes(String);
			DataType = DataType.UInt8;
			IsArray = true;
		}

		public DataToken(byte[] Values)
		{
			Bytes = Values;
			DataType = DataType.UInt8;
			IsArray = true;
		}
	}

	public enum DataType : byte
	{
		Int8,
		UInt8,
		Int16,
		UInt16,
		Int32,
		UInt32,
		Float
	}
}
