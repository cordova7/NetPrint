# NetPrint

> Folder-watching print station for small copy shops, kiosks, and offices.
> Estación de impresión por carpeta para cibercafés, papelerías y oficinas.

NetPrint watches a network folder for new PDF files and prints them
automatically to the configured printer. It also includes a special **INE mode**
that splits scanned 2-up Mexican voter-ID (INE/IFE) pages into individual
cards and a built-in cash register that tallies each job by page, paper size,
and color mode.

NetPrint vigila una carpeta de red para detectar archivos PDF nuevos y los
imprime automáticamente en la impresora configurada. Incluye un **modo INE**
especial que parte hojas escaneadas con dos credenciales del INE/IFE en hojas
individuales, y una caja registradora que lleva el total de cada trabajo por
página, tamaño de papel y modo (color o blanco y negro).

---

## Features / Características

- **Folder watcher** — drop a PDF in the watched folder, NetPrint prints it.
- **Five parallel tasks** — pre-configure different print jobs (paper size,
  duplex/simplex, copies, color, INE mode) and route the same PDF through
  them in sequence.
- **INE mode** — splits 2-up scanned Mexican voter-ID pages into single
  cards using PdfSharp (configurable crop offsets).
- **Cash register** — running total per session, with per-job pricing
  configurable per paper size and color.
- **Per-paper-size printers** — assign different Windows printers to
  *Carta* (Letter), *Oficio* (Legal), and *Color* queues.
- **Printer engine** — uses SumatraPDF in command-line mode for silent,
  unattended printing.

---

## Requirements / Requisitos

- Windows 7 or newer / Windows 7 o superior
- .NET Framework 4.7.2
- [SumatraPDF](https://www.sumatrapdfreader.org/) installed at the default
  location (`C:\Program Files\SumatraPDF\SumatraPDF.exe`)

---

## Quick start / Inicio rápido

1. Build the solution with Visual Studio (or `msbuild`).
2. Run `NetPrint.exe`. The main window opens and the folder watcher starts.
3. Click **Options / Opciones** and configure:
   - The folder to watch (`Carpeta del escáner`).
   - Your printers for *Carta*, *Oficio*, *Color*, and *INE*.
   - Per-job pricing for each paper size and color mode.
4. Drop a PDF into the watched folder. NetPrint prints it.

1. Compila la solución con Visual Studio (o `msbuild`).
2. Ejecuta `NetPrint.exe`. Se abre la ventana principal y el vigilante
   de carpetas arranca.
3. Haz clic en **Opciones** y configura:
   - La carpeta que se va a vigilar (`Carpeta del escáner`).
   - Las impresoras para *Carta*, *Oficio*, *Color* e *INE*.
   - Los precios por trabajo para cada tamaño de papel y modo de color.
4. Deja caer un PDF en la carpeta vigilada. NetPrint lo imprime.

---

## UI controls / Controles de la interfaz

| Control                  | Purpose                                                |
|--------------------------|--------------------------------------------------------|
| Start! / Stop!           | Enable or disable the folder watcher.                  |
| Copies / Copias          | Number of copies for the next print job.               |
| INE                      | Treat the next PDF as a 2-up INE scan.                 |
| Duplex                   | Print the next job in duplex (doble cara).             |
| Color                    | Route the next job to the color printer and pricing.   |
| Tarea 1-5                | Pre-configured print slots. Tick to enable.            |
| Ventas                   | Running cash-register log of every job printed.        |
| Opciones                 | Open the settings dialog (folder, printers, prices).   |
| << / >>                  | Collapse or expand the side panel.                     |

| Control                  | Función                                                 |
|--------------------------|---------------------------------------------------------|
| Start! / Stop!           | Activa o desactiva el vigilante de carpeta.             |
| Copias                   | Número de copias del siguiente trabajo.                 |
| INE                      | Trata el siguiente PDF como escaneo INE 2-up.           |
| Duplex                   | Imprime el siguiente trabajo a doble cara.              |
| Color                    | Envía el siguiente trabajo a la impresora de color.     |
| Tarea 1-5                | Espacios preconfigurados de impresión.                  |
| Ventas                   | Registro acumulativo de cada trabajo impreso.           |
| Opciones                 | Abre el diálogo de ajustes (carpeta, impresoras, precios). |
| << / >>                  | Contrae o expande el panel lateral.                     |

---

## Settings file / Archivo de configuración

User settings live at:
`%LOCALAPPDATA%\NetPrint\NetPrint.exe_Url_*.user.config`

The defaults are seeded from `NetPrint/App.config`.

---

## Project layout / Estructura del proyecto

| File                       | Role                                                  |
|----------------------------|-------------------------------------------------------|
| `Program.cs`               | Entry point.                                          |
| `MainForm.cs`              | Main UI and folder watcher.                           |
| `MainForm.Designer.cs`     | WinForms designer code for the main window.           |
| `Parameters.cs`            | Per-job print parameters (paper, mode, copies, ...).  |
| `SumatraPrinter.cs`        | Wraps `SumatraPDF.exe -print-to` calls.               |
| `Venta.cs`                 | Cash-register math per job.                           |
| `Options.cs`               | Settings dialog (printers, folder, pricing).          |
| `INEadvancedOptions.cs`    | Crop-offset editor for the INE splitter.              |
| `Properties/Settings.*`    | Strongly-typed `Settings.Default` accessor.           |
| `PdfSharp/`                | Vendored copy of PdfSharp for the INE splitter.       |

---

## License / Licencia

This project is provided as-is for personal and commercial use.
PdfSharp is bundled under its own MIT-style license; see `PdfSharp/` for
details.

Este proyecto se proporciona tal cual para uso personal y comercial.
PdfSharp se incluye bajo su propia licencia tipo MIT; consulta `PdfSharp/`
para más detalles.