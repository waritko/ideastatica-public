﻿using IdeaStatiCa.Api.Connection.Model;
using IdeaStatiCa.ConnectionApi;

namespace CodeSamples
{
	public partial class ClientExamples
	{
		/// <summary>
		/// Save the pdf report of a given connection.
		/// </summary>
		/// <param name="conClient">The connected API Client</param>
		public static async Task SaveReport_Pdf(ConnectionApiClient conClient)
		{
			string filePath = "Inputs/simple cleat connection.ideaCon";
			ConProject conProject = await conClient.Project.OpenProjectAsync(filePath);

			//Get projectId Guid
			Guid projectId = conProject.ProjectId;
			var connections = await conClient.Connection.GetConnectionsAsync(projectId);
			int connectionId = connections[0].Id;

			string exampleFolder = GetExampleFolderPathOnDesktop("GenerateReport");

			// Save updated file.
			string fileName = "simple cleat connection.pdf";
			string pdfFilePath = Path.Combine(exampleFolder, fileName);

			//Save Report to PDF
			await conClient.Report.SaveReportPdfAsync(projectId, connectionId, pdfFilePath);

			Console.WriteLine($"Report saved to: {pdfFilePath}");

			//Close the opened project.
			await conClient.Project.CloseProjectAsync(projectId);
		}
	}
}
