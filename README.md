# VKDialogFileMerger

[![en](https://img.shields.io/badge/lang-en-blue.svg)](https://github.com/wh0o7/VKDialogFileMerger/blob/main/README.md) [![ru](https://img.shields.io/badge/lang-ru-red.svg)](https://github.com/wh0o7/VKDialogFileMerger/blob/main/README.ru-ru.md)

VKDialogFileMerger is an application that allows you to merge dialogue files extracted from VKontakte (VK) archives into a single dialogue file. The messages in VK dialogue files are split into separate files, with each file containing 50 messages. VKDialogFileMerger simplifies the process of combining these files into a unified dialogue file.

VKDialogFileMerger provides two versions:

## CLI (Cross-platform)

The CLI version of VKDialogFileMerger is a command-line tool that supports multiple platforms, including Windows and Linux. It offers the following parameters:

- `-i, --inputpath`: Specifies the path to the directory containing the dialogue files. If not provided, the current directory is used.
- `-c, --addCss`: Adds CSS styling inside the merged file.
- `-o, --outputpath`: Specifies the output path for the merged file. If not provided, the merged file is saved in the same directory as the executable.

### Example Usage (Windows):

```
VKDialogFileMerger.exe -i "C:\Path\To\Dialogue\Files" -c -o "C:\Path\To\Output\File.txt"
```

### Example Usage (Linux):

```
./VKDialogFileMerger -i "/path/to/dialogue/files" -c -o "/path/to/output/file.txt"
```

### Example Usage with Opening via exe:

1. Move the executable file `VKDialogFileMerger.exe` to the folder containing the dialogue files.
2. Run the `VKDialogFileMerger.exe` file.
3. In the dialog window that appears, choose one of the following options:
    - Press `Y` to apply CSS styles to the merged file.
    - Press `N` (or any other key) to decline embedding CSS styles in the merged file.
4. After successfully merging the dialogue, you will see a message in the console with the name of the resulting file.

## GUI (Windows only)

The GUI version of VKDialogFileMerger is a Windows-only application that provides a graphical user interface for selecting input and output paths.

To use the GUI version, simply run the executable, and a file dialog will appear allowing you to choose the input directory and specify the output file path. If no input or output paths are selected, the application will default to the directory where the executable is located.

## Questions or Feedback? 🤔

If you have any questions or want to provide feedback, you can reach out to me in the [wh0o7 heaven chat](https://t.me/+D-T_xElzA003Nzcy). Let's make the project even better together! 🎵🎉

## License

This project is licensed under the [MIT License](LICENSE).

## Runtime

Please note that before using the CLI version, you need to download and install the .NET 6 runtime from [the official .NET website](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). The GUI version is specifically designed for Windows and can be downloaded as a separate executable from the [Releases page](https://github.com/Andruxxa7/VKDialogFileMerger/releases) or built by yourself after cloning the repository.
