# ByteSweep

**ByteSweep** is a native Windows utility built with **C# and WPF**. It provides an intelligent, system-wide file scanner that analyzes files, cleans metadata, gathers forensic data, and flags suspicious content — all from a modern UI.

Unlike standard cleanup tools, ByteSweep focuses on **automated, deep file scanning** across full drives or directories, helping users or investigators uncover hidden threats or unnecessary data without manual file-by-file selection.

---

## Planned Features

### Path & System Scanning
- Select a **custom folder**, specific drive, or trigger a **full system scan**.
- Recursive, multi-threaded scanning for speed.
- Real-time progress tracking and logging.

### File Cleaning
- **Strip metadata** (timestamps, authorship, properties).
- **Secure deletion** using multiple overwrite passes (DoD/NSA-style wipes).
- Basic **steganography detection** (flagging files with hidden payload patterns).

### File Analysis & Stats
- Generate **SHA-256 / MD5** hashes for every file.
- Flag **compressed or encrypted** files.
- Categorize by:
  - File type (extension)
  - Size ranges
  - Creation / modification dates

### Malware Detection
- Optional **VirusTotal API integration** for online hash lookup.
- Local threat hash DB (JSON or SQLite).
- Basic heuristics (e.g. high entropy, suspicious naming, system directory location).

### WPF User Interface
- Modern, clean WPF layout with:
  - Folder/system scan buttons
  - Logs and scan stats
  - Threat indicators
  - Exportable report (CSV, JSON, PDF)
- Theme support (Light/Dark)

---

##  TODO Checklist

### Core Setup
- [ ] Create WPF project `ByteSweep`
- [ ] Set up MVVM structure
- [ ] Build UI:
  - [ ] Folder selection
  - [ ] System scan trigger
  - [ ] Log window
  - [ ] Scan status/progress

### Scanner Engine
- [ ] Implement recursive scanner
- [ ] Add drive enumeration and system-wide scanning
- [ ] Handle access-denied exceptions and symlink loops

### Cleaner Tools
- [ ] Strip file metadata (via Shell32 / file properties APIs)
- [ ] Secure file wipe (multi-pass overwrite before delete)

### Statistics Engine
- [ ] SHA-256 / MD5 hashing
- [ ] File classification logic
- [ ] Entropy calculation (for encryption detection)

### Threat Analysis
- [ ] Optional VirusTotal query
- [ ] Heuristic risk scoring

### Testing
- [ ] Local directory scan
- [ ] C:\ full scan with logging
- [ ] Corrupt/locked file handling

## Bonus Feature Ideas

- **Quarantine System**: Move flagged files to a safe zone.
- **Scheduled Scans**: Set daily/weekly scans using Windows Task Scheduler.
- **AI Classification (future idea)**: Use ML.NET to analyze file traits.
- **Notification System**: Desktop toast messages for scan results or alerts.
- **Report Upload**: Send reports to a central server or email.
- **Portable Version**: Build as a self-contained .exe with no installer.
