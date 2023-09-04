using System.Diagnostics;

using (Process process = new Process())
{
    process.StartInfo.FileName  = "dotnet-repl";
    process.StartInfo.Arguments = $" --run Script.dib --exit-after-run ";

    process.Start();
    process.WaitForExit();
}
