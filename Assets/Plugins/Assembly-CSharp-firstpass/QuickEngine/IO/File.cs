using System;
using System.Collections.Generic;
using System.IO;

namespace QuickEngine.IO
{
	public static class File
	{
		private static List<string> listOfStrings;

		private static FileInfo[] fileInfoArray;

		private static DirectoryInfo[] directoryInfoArray;

		public static bool Exists(string path)
		{
			return false;
		}

		public static void CreateDirectory(string path)
		{
		}

		public static string GetAbsoluteDirectoryPath(string directoryName, bool debug = false)
		{
			return null;
		}

		public static string GetRelativeDirectoryPath(string directoryName)
		{
			return null;
		}

		public static void WriteFile<T>(string filePath, T obj, Action<FileStream, T> serializeMethod)
		{
		}

		public static void Delete(string path)
		{
		}

		public static void Move(string sourceFileName, string destFileName)
		{
		}

		public static void Rename(string sourceFileName, string destFileName)
		{
		}

		public static FileInfo[] GetFiles(string directoryPath)
		{
			return null;
		}

		public static FileInfo[] GetFiles(string directoryPath, string fileExtension)
		{
			return null;
		}

		public static string[] GetFilesNames(string directoryPath)
		{
			return null;
		}

		public static string[] GetFilesNames(string directoryPath, string fileExtension)
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories(string directoryPath)
		{
			return null;
		}

		public static string[] GetDirectoriesNames(string directoryPath)
		{
			return null;
		}
	}
}
