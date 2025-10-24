# Jurassic - Geospatial Image Viewer

A Windows Forms application for viewing and navigating orthophoto tiles of the Jura region. This application provides an interactive grid-based interface for exploring high-resolution aerial imagery.

## Overview

Jurassic is a C# Windows Forms application that displays orthophoto tiles in a DataGridView format, allowing users to:
- View a grid of 30x30 pixel thumbnails representing larger 3000x3000 pixel orthophoto tiles
- Click on any tile to view the full-resolution image in a separate window
- Navigate to specific coordinates by entering UTM coordinates
- Open images in external applications for editing

## Features

- **Grid-based Navigation**: 68x93 grid displaying orthophoto thumbnails
- **Coordinate System**: UTM coordinate system with defined boundaries
- **Interactive Viewing**: Click any tile to view full-resolution image
- **Coordinate Search**: Enter specific X,Y coordinates to jump to a location
- **External Editing**: Open images in default system application

## Geographic Coverage

The application covers the Jura region with the following UTM coordinate boundaries:
- **X Range**: 497,570m to 565,570m (68,000m span)
- **Y Range**: 245,711m to 336,711m (91,000m span)
- **Grid Resolution**: 1000m per tile
- **Tile Size**: 3000x3000 pixels per full-resolution image

## Technical Details

- **Framework**: .NET Framework 3.5
- **Language**: C#
- **UI**: Windows Forms
- **Image Format**: JPG
- **Coordinate System**: UTM

## File Structure

```
Jurassic/
├── Form1.cs              # Main application form with grid display
├── Form1.Designer.cs     # UI designer code for main form
├── Form2.cs              # Image viewer form
├── Form2.Designer.cs     # UI designer code for viewer form
├── Program.cs            # Application entry point
├── Jurassic.csproj       # Visual Studio project file
└── Properties/           # Application properties and resources
```

## Image Data Requirements

The application expects image files to be organized in the following structure:
- **Thumbnails**: `set_30px_30px/Jura_[X]_[Y].jpg` (30x30 pixel thumbnails)
- **Full Images**: `set/Jura_[X]_[Y].jpg` (3000x3000 pixel full images)

Where:
- `[X]` = Column number × 3000 (0, 3000, 6000, ...)
- `[Y]` = Row number × 3000 (0, 3000, 6000, ...)

## Usage

1. **Grid Navigation**: Click on any cell in the grid to view the full-resolution image
2. **Coordinate Search**: 
   - Enter X and Y coordinates in the text boxes
   - Click "Wyświetl region" to jump to that location
3. **Image Editing**: In the image viewer, click "Edit" to open the image in your default image editor

## Building and Running

### Prerequisites
- Visual Studio 2008 or later
- .NET Framework 3.5 or later

### Build Instructions
1. Open `Jurassic.csproj` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run the application (F5)

### Executable
Pre-compiled executables are available in:
- `bin/Debug/Jurassic.exe` (Debug version)
- `bin/Release/Jurassic.exe` (Release version)

## Development History

This application was originally developed in November 2010 as a tool for exploring orthophoto data from the Polish Geoportal. The codebase represents an early implementation of geospatial image viewing using Windows Forms.

## License

This project appears to be a custom application for geospatial data exploration. Please ensure you have appropriate rights to use any associated image data.

## Notes

- The application is designed for Polish orthophoto data from the Geoportal
- Image paths are hardcoded and may need adjustment for different data sources
- The coordinate system uses UTM projection
- Grid dimensions are fixed at 68 columns × 93 rows
