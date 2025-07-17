Kafka Chat App Using C# (.NET) on Windows
This project showcases how to build a real-time chat system using Apache Kafka as the messaging backbone and C# (.NET) for the application logic. Messages are exchanged between users using Kafka topics — where one user sends messages (Producer) and another receives them (Consumer) in real time.

📌 What is Apache Kafka?
Apache Kafka is an open-source distributed platform designed for high-performance, real-time data streaming. It:

Supports high-throughput data pipelines

Follows a publish-subscribe model

Is resilient, scalable, and persistent

Kafka is commonly used in:

Real-time data analytics

Centralized log collection

Messaging and event-based systems

Event sourcing architectures

🧠 Project Structure
Producer App: A .NET console application that sends chat messages to Kafka.

Consumer App: A separate console app that subscribes to Kafka and receives/display messages.

Kafka: Acts as the message broker, routing data between producer and consumer.

Zookeeper: Provides coordination services for Kafka brokers.

🛠 Technology Stack
Apache Kafka: v3.6.1 (Scala 2.13 build)

Java: Version 21 (LTS recommended)

.NET: Version 7.0+ (develop using Visual Studio 2022)

NuGet Library: Confluent.Kafka

🔧 Setting Up Kafka & Zookeeper on Windows
✅ Step 1: Launch Zookeeper
Open Command Prompt 1 and run:

bash
Copy
Edit
cd C:\kafka\bin\windows
zookeeper-server-start.bat ..\..\config\zookeeper.properties
Zookeeper is necessary for Kafka to manage cluster coordination.

✅ Step 2: Start Kafka Broker
Open Command Prompt 2 and run:

bash
Copy
Edit
cd C:\kafka\bin\windows
kafka-server-start.bat ..\..\config\server.properties
This starts the Kafka server, listening on localhost:9092.

✅ Step 3: Create a Kafka Topic (Run only once)
Open Command Prompt 3 and run:

bash
Copy
Edit
cd C:\kafka\bin\windows
kafka-topics.bat --create --topic chat-topic --bootstrap-server localhost:9092 --partitions 1 --replication-factor 1
This sets up a chat-topic where messages will be sent and received.

📥 Kafka Installation (Windows)
✅ Download Kafka
Visit the official Kafka downloads page and download:

kafka_2.13-3.6.1.tgz

Extract the archive to:

C:\kafka

This completes your local Kafka setup.