# 🛡️ Cybersecurity Awareness Chatbot

A modular, console-based C# application designed to educate users on cybersecurity through an interactive interface. The system features keyword-based response matching, context tracking, and audio capabilities.

---

## 🏗️ System Architecture

The project follows a decoupled architecture, separating data handling, business logic, and user interface components:

### 📂 Directory Structure
* **`Chatbot/`**: Core engine logic, ASCII art, and UI formatting.
* **`Services/`**: JSON data loading and response matching logic.
* **`Models/`**: Data contracts for responses.
* **`Utilities/`**: Input validation and helper methods.
* **`Data/`**: Contains `responses.json` (The knowledge base).
* **`Audio/`**: Contains `greeting.wav` for the voice intro.

---

## 🚀 Key Features

* **Keyword Engine**: Uses Regular Expressions to clean user input and match it against a predefined knowledge base.
* **Multimedia Integration**: Includes a `VoiceGreeting` service using `NAudio` to play a WAV file on startup.
* **State Management**: A `ConversationContext` class tracks the user's last discussed topic.
* **Themed UI**: Custom `UIFormatter` providing color-coded console output (Yellow for art, Green for users, Cyan for the bot).
* **Robust Data Loading**: Decoupled `JsonResponseLoader` to fetch data from external JSON files.

---

## 🛠️ Technical Stack

* **Language**: C# (.NET)
* **Libraries**:
    * `System.Text.Json`: For parsing the knowledge base.
    * `NAudio`: For handling audio playback.
    * `System.Text.RegularExpressions`: For input normalization.

---

## 📋 Class Overview

| Class | Responsibility |
| :--- | :--- |
| **`Program`** | Entry point; initializes services and starts the engine. |
| **`ChatbotEngine`** | The main loop; handles input/output flow. |
| **`ResponseService`** | Logic for finding the best reply based on keywords. |
| **`JsonResponseLoader`** | Reads and deserializes the `responses.json` file. |
| **`VoiceGreeting`** | Manages the playback of the initial audio greeting. |
| **`UIFormatter`** | Centralizes console color and prefixing logic. |
| **`AsciiArt`** | Displays the visual branding of the application. |

---

## ⚙️ Configuration

To customize the bot's knowledge, edit the `Data/responses.json` file following this structure:

```json
[
  {
    "Keyword": "Phishing",
    "Reply": "Phishing is a method where attackers send fake emails to steal your data."
  },
  {
    "Keyword": "Firewall",
    "Reply": "A firewall monitors and filters incoming and outgoing network traffic."
  }
]
```

---

## 🏁 Getting Started

1.  **Audio Setup**: Ensure a file named `greeting.wav` exists in the `/Audio` folder within your output directory.
2.  **Data Setup**: Ensure `responses.json` is located in the `/Data` folder.
3.  **Run**: Execute the program. You will see the ASCII banner, hear the greeting, and can start typing cybersecurity questions.
4.  **Exit**: Type `exit` to close the application safely.

> **Note**: This project requires the **NAudio** NuGet package to be installed for the voice greeting feature to function.
