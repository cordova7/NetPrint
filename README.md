# NetPrint

Folder-watching print station for small copy shops, kiosks, and offices.

Estacion de impresion por carpeta para cibercafs, papeleria y oficinas.

---

## Features

- **Folder watcher** — drop a PDF in the watched folder, NetPrint prints it.
- **Five parallel tasks** — pre-configure different print jobs (paper size, duplex/simplex, copies, color, ID mode) and route the same PDF through them in sequence.
- **ID mode** — splits 2-up scanned Mexican ID pages into single cards using PdfSharp (configurable crop offsets).
- **Cash register** — running total per session, with per-job pricing configurable per paper size and color.
- **Per-paper-size printers** — assign different Windows printers to Carta (Letter), Oficio (Legal), and Color queues.
- **Printer engine** — uses SumatraPDF in command-line mode for silent, unattended printing.

## Caracteristicas

- **Vigilante de carpeta** — deja caer un PDF en la carpeta vigilada y NetPrint lo imprime.
- **Cinco tareas paralelas** — preconfigura diferentes trabajos de impresion (tamano de papel, doble cara/sencilla, copias, color, modo ID) y envia el mismo PDF por todos ellos en secuencia.
- **Modo ID** — parte hojas escaneadas con dos credenciales del ID en hojas individuales usando PdfSharp (offsets de recorte configurables).
- **Caja registradora** — total acumulado por sesion, con precios por trabajo configurables por tamano de papel y color.
- **Impresoras por tamano** — asigna diferentes impresoras de Windows a las colas Carta (Letter), Oficio (Legal) y Color.
- **Motor de impresion** — usa SumatraPDF en modo linea de comandos para impresion silenciosa y sin supervision.

---

## Requirements

- Windows 7 or newer
- .NET Framework 4.7.2
- [SumatraPDF](https://www.sumatrapdfreader.org/) installed at the default location (`C:\Program Files\SumatraPDF\SumatraPDF.exe`)

## Requisitos

- Windows 7 o superior
- .NET Framework 4.7.2
- [SumatraPDF](https://www.sumatrapdfreader.org/) instalado en la ubicacion predeterminada (`C:\Program Files\SumatraPDF\SumatraPDF.exe`)

---

## Quick start

1. Build the solution with Visual Studio (or `msbuild`).
2. Run `NetPrint.exe`. The main window opens and the folder watcher starts.
3. Click **Opciones** and configure:
   - The folder to watch.
   - Your printers for Carta, Oficio, Color, and INE.
   - Per-job pricing for each paper size and color mode.
4. Drop a PDF into the watched folder. NetPrint prints it.

## Inicio rapido

1. Compila la solucion con Visual Studio (o `msbuild`).
2. Ejecuta `NetPrint.exe`. Se abre la ventana principal y el vigilante de carpetas arranca.
3. Haz clic en **Opciones** y configura:
   - La carpeta que se va a vigilar.
   - Las impresoras para Carta, Oficio, Color e INE.
   - Los precios por trabajo para cada tamano de papel y modo de color.
4. Deja caer un PDF en la carpeta vigilada. NetPrint lo imprime.

---

## UI controls

| Control       | Purpose                                              |
|---------------|------------------------------------------------------|
| Start! / Stop! | Enable or disable the folder watcher.              |
| INE           | Treat the next PDF as a 2-up INE scan.              |
| Duplex        | Print the next job in duplex (two-sided).            |
| Color         | Route the next job to the color printer and pricing. |
| Tarea 1-5     | Pre-configured print slots. Tick to enable.         |
| Ventas        | Running cash-register log of every job printed.      |
| Opciones      | Open the settings dialog.                           |
| << / >>       | Collapse or expand the side panel.                   |

## Controles de la interfaz

| Control       | Funcion                                               |
|---------------|-------------------------------------------------------|
| Start! / Stop! | Activa o desactiva el vigilante de carpeta.          |
| INE           | Trata el siguiente PDF como escaneo ID 2-up.        |
| Duplex        | Imprime el siguiente trabajo a doble cara.            |
| Color         | Envia el siguiente trabajo a la impresora de color.  |
| Tarea 1-5     | Espacios preconfigurados de impresion. Marca para activar. |
| Ventas        | Registro acumulativo de cada trabajo impreso.          |
| Opciones      | Abre el dialogo de ajustes.                           |
| << / >>       | Contrae o expande el panel lateral.                  |

---

## Settings file

User settings live at:

`%LOCALAPPDATA%\NetPrint\NetPrint.exe_Url_*.user.config`

The defaults are seeded from `NetPrint/App.config`.

## Archivo de configuracion

La configuracion del usuario se guarda en:

`%LOCALAPPDATA%\NetPrint\NetPrint.exe_Url_*.user.config`

Los valores predeterminados vienen de `NetPrint/App.config`.

---

## Project layout

| File                     | Role                                                    |
|--------------------------|---------------------------------------------------------|
| `Program.cs`             | Entry point.                                            |
| `MainForm.cs`            | Main UI and folder watcher.                             |
| `MainForm.Designer.cs`   | WinForms designer code for the main window.             |
| `Parameters.cs`          | Per-job print parameters (paper, mode, copies, ...).    |
| `SumatraPrinter.cs`     | Wraps `SumatraPDF.exe -print-to` calls.                |
| `Venta.cs`               | Cash-register math per job.                             |
| `Options.cs`             | Settings dialog (printers, folder, pricing).            |
| `INEadvancedOptions.cs`  | Crop-offset editor for the INE splitter.               |
| `Properties/Settings.*`  | Strongly-typed `Settings.Default` accessor.             |
| `PdfSharp/`, `PdfSharp-gdi/` | Vendored PdfSharp (core + GDI build) used by the INE splitter. WPF and Charting variants are intentionally not vendored. |

## Estructura del proyecto

| Archivo                   | Funcion                                                  |
|---------------------------|---------------------------------------------------------|
| `Program.cs`              | Punto de entrada.                                       |
| `MainForm.cs`             | Interfaz principal y vigilante de carpeta.             |
| `MainForm.Designer.cs`    | Codigo de diseador WinForms de la ventana principal.    |
| `Parameters.cs`           | Parametros de impresion por trabajo (papel, modo, copias, ...). |
| `SumatraPrinter.cs`       | Envoltura de llamadas `SumatraPDF.exe -print-to`.        |
| `Venta.cs`                | Matematicas de caja registradora por trabajo.           |
| `Options.cs`              | Dialogo de configuracion (impresoras, carpeta, precios). |
| `INEadvancedOptions.cs`   | Editor de offsets de recorte para el divisor INE.       |
| `Properties/Settings.*`   | Acceso tipado a `Settings.Default`.                      |
| `PdfSharp/`, `PdfSharp-gdi/` | PdfSharp incluido (nucleo + build GDI) usado por el divisor INE. Las variantes WPF y Charting no se incluyen intencionalmente. |

---

## License

This project is provided as-is for personal and commercial use.

PdfSharp is bundled under its own MIT-style license; see `PdfSharp/` for details.

## Licencia

Este proyecto se proporciona tal cual para uso personal y comercial.

PdfSharp se incluye bajo su propia licencia tipo MIT; consulta `PdfSharp/` para mas detalles.
