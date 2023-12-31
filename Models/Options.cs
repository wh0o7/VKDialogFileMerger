#nullable enable
using CommandLine;

namespace VKDialogHistoryFileMerger.Models;

public class Options
{
    [Option('i', "inputpath", Required = false, HelpText = "Path to the dialog files directory.")]
    public string Path { get; set; } = ".";

    [Option('c', "addCss", Required = false, HelpText = "Add CSS inside the merged file.")]
    public bool AddCss { get; set; }

    [Option('o', "outputpath", Required = false, HelpText = "Output path for the merged file.")]
    public string? OutputPath { get; set; } = null;
}