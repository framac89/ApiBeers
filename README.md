# 🍺 Beer Discovery App (.NET)

Un'applicazione console robusta e intelligente per la gestione e la scoperta di birre. Il programma ottimizza le richieste alle API esterne salvando automaticamente i risultati in un database locale per consultazioni future.

---

## 🧐 Come funziona
L'applicazione segue una logica di recupero dati efficiente:
1. **Input Utente:** L'utente inserisce il nome di una birra.
2. **Controllo Database:** Il programma verifica se la birra è già presente nel database locale (SQLite/SQL Server).
3. **Fallback su API:** Se non viene trovata, l'app interroga l'API esterna **Beer9** tramite RapidAPI.
4. **Persistenza:** Una volta trovata tramite API, la birra viene mostrata all'utente e contestualmente **salvata nel database** per rendere istantanee le ricerche successive.

---

## 🛠️ Tecnologie utilizzate
- **C# / .NET**
- **Entity Framework Core** (Gestione database e migrazioni)
- **RapidAPI (Beer9)** (Sorgente dati esterna)
- **JSON** (Configurazione delle API Key)

---

## 🚀 Configurazione e Installazione

Segui questi passaggi per configurare il progetto sul tuo computer:

### 1. Ottenere la API Key
Il progetto richiede una chiave valida per funzionare. Puoi ottenerne una gratuitamente qui:
👉 [RapidAPI - Beer9 API](https://rapidapi.com/winevybe/api/beer9/)

### 2. Configurazione file appsettings
Per motivi di sicurezza, le chiavi non sono incluse nel codice.
- Copia il file `appsettings.example.json` e nominalo `appsettings.json`.
- Inserisci la tua API Key e le altre informazioni richieste all'interno del file.

### 3. Preparazione dell'ambiente
Apri il terminale nella cartella del progetto ed esegui i seguenti comandi:

**Ripristina i pacchetti NuGet:**
```bash
dotnet restore
