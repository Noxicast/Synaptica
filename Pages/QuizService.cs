namespace Synaptica.Pages
{
    public static class QuizService
    {
        public static List<QuizQuestion> GetQuestionsByQuizId(int quizId)
        {
            return quizId switch
            {
              
                1 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the output of `print(2 ** 3)` in Python?", Options = new List<string> { "6", "8", "9", "5" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of these is a mutable data type in Python?", Options = new List<string> { "Tuple", "String", "List", "Integer" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What keyword is used to define a function in Python?", Options = new List<string> { "func", "function", "def", "define" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which Python library is used for data analysis?", Options = new List<string> { "NumPy", "pandas", "matplotlib", "scipy" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the correct file extension for Python files?", Options = new List<string> { ".py", ".python", ".p", ".pyth" }, CorrectAnswer = 0 },
                },

            ///////////////////////////////////////////////////////////////////////////// added new quizzes to respective course
                2 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which function in pandas is used to load a CSV file?", Options = new List<string> { "read_csv()", "load_csv()", "open_csv()", "csv_read()" }, CorrectAnswer = 0  },
                    new QuizQuestion { Question = "What is the output of `len([1, 2, 3, 4, 5])` in Python?", Options = new List<string> { "4", "5", "6", "Error" },CorrectAnswer = 1},
                    new QuizQuestion { Question = "What is the purpose of the `DataFrame` in pandas?", Options = new List<string> { "Store tabular data", "Visualize data", "Perform statistical analysis", "Optimize Python code" }, CorrectAnswer = 0  },
                },


                3 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What does the term 'cloud security' refer to?", Options = new List<string> { "Securing physical data centers", "Protecting cloud-based systems, data, and applications", "Installing antivirus software", "Backing up files to the cloud"  }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is a common risk in cloud computing?", Options = new List<string>{"Data breaches","Improved scalability", "Faster application development","Enhanced collaboration" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the purpose of encryption in cloud security?", Options = new List<string> { "To compress data for faster transmission", "To prevent unauthorized access to data", "To improve application speed", "To backup data automatically" }, CorrectAnswer = 1   },
                },

                4 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which term refers to the process of verifying a user's identity?", Options = new List<string> { "Authentication", "Authorization",  "Access control", "Data masking" }, CorrectAnswer = 0   },
                    new QuizQuestion { Question = "What is 'multi-factor authentication' (MFA)?", Options = new List<string>{ "Using multiple passwords for security",  "A method of requiring two or more verification methods for access", "Encrypting data in multiple formats", "A type of firewall"  }, CorrectAnswer = 1},
                    new QuizQuestion { Question = "Which of the following is a shared responsibility in cloud security?", Options = new List<string>   { "Data encryption by the cloud provider", "Network configuration by the user",  "Hardware maintenance by the user",  "Physical security of data centers by the user" }, CorrectAnswer = 1   },
                },

                5 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which programming language is commonly used for Android development?", Options = new List<string> { "Kotlin", "Swift", "JavaScript", "C#" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the official IDE for Android development?", Options = new List<string> { "Eclipse", "Xcode", "Android Studio", "Visual Studio" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which of these is a cross-platform mobile development framework?", Options = new List<string> { "Flutter", "Node.js", "TensorFlow", "Unity" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the default file format for Android layout files?", Options = new List<string> { ".layout", ".json", ".html", ".xml" }, CorrectAnswer = 3 },
                },

                6 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which tool is used to design user interfaces in iOS development?", Options = new List<string> { "Interface Builder", "Storyboard Designer", "UI Designer", "App Layout" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which programming language is primarily used for iOS development?", Options = new List<string> { "Kotlin", "Swift", "C++", "Python" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the purpose of an emulator in mobile app development?", Options = new List<string> { "To publish apps to app stores", "To compile code faster", "To debug code directly on hardware", "To test apps on a virtual device" }, CorrectAnswer = 3 },
                    new QuizQuestion { Question = "Which of the following is a lifecycle method in Android?", Options = new List<string> { "onCreate()", "onStartApp()", "onRun()", "onDestroyApp()" }, CorrectAnswer = 0 },
                },

                7 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which device is used to connect multiple networks together?", Options = new List<string> { "Switch", "Router", "Hub", "Access Point" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What does the acronym 'DNS' stand for?", Options = new List<string> { "Domain Name System", "Data Network Service", "Dynamic Network Server", "Domain Network Service" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the default subnet mask for a Class C IP address?", Options = new List<string> { "255.0.0.0", "255.255.0.0", "255.255.255.0", "255.255.255.255" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which protocol is used to securely transfer files?", Options = new List<string> { "HTTP", "FTP", "SFTP", "SMTP" }, CorrectAnswer = 2 },
                 },

                8 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the primary purpose of a firewall?", Options = new List<string> { "To speed up the network", "To block unauthorized access", "To compress data", "To monitor hardware" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which layer of the OSI model is responsible for routing?", Options = new List<string> { "Data Link", "Network", "Transport", "Application" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What does the command 'ping' test?", Options = new List<string> { "Internet speed", "Connectivity to a host", "Packet loss", "DNS resolution" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is a private IP address?", Options = new List<string> { "8.8.8.8", "192.168.1.1", "172.64.0.1", "203.0.113.1" }, CorrectAnswer = 1 },
                },

                9 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which programming language is primarily used in Unity?", Options = new List<string> { "C++", "Java", "C#", "Python" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What is the default 3D coordinate system used in Unity?", Options = new List<string> { "Left-Handed", "Right-Handed", "Cartesian", "Polar" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the purpose of Unity's GameObject?", Options = new List<string> { "Render 3D models", "Hold components and represent objects in the scene", "Define the player's controls", "Compile scripts" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which Unity component is required to make an object visible in a scene?", Options = new List<string> { "Rigidbody", "Renderer", "Transform", "Collider" }, CorrectAnswer = 1 },
                },

                10 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the function of Unity's Rigidbody component?", Options = new List<string> { "Apply physics to GameObjects", "Detect collisions", "Enable scripting", "Control animations" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which Unity tool is used to create navigation paths for AI?", Options = new List<string> { "NavMesh", "PathFinder", "AI Grid", "Waypoint System" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What file format is commonly used to import 3D models into Unity?", Options = new List<string> { ".fbx", ".png", ".wav", ".cs" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is Unity's primary scripting environment?", Options = new List<string> { "MonoDevelop", "Visual Studio", "Rider", "JetBrains" }, CorrectAnswer = 1 },
                },

                11 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is a blockchain?", Options = new List<string> { "A type of cryptocurrency", "A distributed ledger technology", "A cloud storage system", "A type of database" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which is the first cryptocurrency built on blockchain technology?", Options = new List<string> { "Ethereum", "Ripple", "Bitcoin", "Litecoin" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What does a block in a blockchain typically contain?", Options = new List<string> { "Only transaction data", "Transaction data and a hash", "Encryption keys", "Smart contracts" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What ensures the security of a blockchain?", Options = new List<string> { "Central authority", "Encryption and hashing", "Firewalls", "Manual checks" }, CorrectAnswer = 1 },
                },

                12 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is a 'smart contract' in blockchain?", Options = new List<string> { "A physical contract", "A self-executing digital contract", "An encrypted message", "A mining algorithm" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which consensus mechanism is used by Bitcoin?", Options = new List<string> { "Proof of Stake", "Proof of Work", "Delegated Proof of Stake", "Proof of Authority" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the primary benefit of blockchain technology?", Options = new List<string> { "Faster computation", "Centralized control", "Immutability and transparency", "Low power consumption" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What is 'mining' in the context of blockchain?", Options = new List<string> { "Generating cryptocurrency", "Adding new blocks to the blockchain", "Encrypting data", "Destroying old data" }, CorrectAnswer = 1 },
                },

                13 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is Tableau primarily used for?", Options = new List<string> { "Data storage", "Data visualization", "Data mining", "Data encryption" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is a Tableau file format for packaged workbooks?", Options = new List<string> { ".twbx", ".xlsx", ".csv", ".json" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is a 'dashboard' in Tableau?", Options = new List<string> { "A collection of visualizations on one page", "A data storage interface", "A query builder", "An export tool" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which Tableau feature allows combining data from multiple sources?", Options = new List<string> { "Blending", "Joining", "Filtering", "Pivoting" }, CorrectAnswer = 0 },
                },

                14 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What type of chart is best for showing trends over time?", Options = new List<string> { "Bar chart", "Line chart", "Pie chart", "Scatter plot" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the purpose of Tableau's 'Show Me' feature?", Options = new List<string> { "To filter data", "To suggest visualization types", "To create dashboards", "To export data" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is a 'story' in Tableau?", Options = new List<string> { "A narrative explanation of data insights", "A single visualization", "A chart template", "A data cleaning tool" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which Tableau feature is used to group similar data points?", Options = new List<string> { "Bins", "Sets", "Groups", "Filters" }, CorrectAnswer = 2 },
                },

                15 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "Which keyword in Java is used to achieve abstraction?", Options = new List<string> { "final", "abstract", "interface", "extends" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the purpose of the 'transient' keyword in Java?", Options = new List<string> { "To serialize variables", "To prevent serialization of variables", "To make variables immutable", "To enable multi-threading" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which method is called to start a thread in Java?", Options = new List<string> { "run()", "begin()", "execute()", "start()" }, CorrectAnswer = 3 },
                    new QuizQuestion { Question = "Which collection in Java does not allow duplicate elements?", Options = new List<string> { "List", "Map", "Set", "Queue" }, CorrectAnswer = 2 },
                },

                16 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the purpose of the 'finally' block in exception handling?", Options = new List<string> { "To handle exceptions", "To execute cleanup code", "To define the exception", "To throw an exception" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of these is a marker interface in Java?", Options = new List<string> { "Serializable", "Cloneable", "Both Serializable and Cloneable", "Runnable" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which keyword is used to inherit a class in Java?", Options = new List<string> { "super", "this", "extends", "implements" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What is the default size of a HashMap in Java?", Options = new List<string> { "8", "16", "32", "64" }, CorrectAnswer = 1 },
                },

                17 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What does SEO stand for?", Options = new List<string> { "Search Essential Optimization", "Search Engine Optimization", "System Engine Optimization", "Search Engine Operation" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is an example of paid marketing?", Options = new List<string> { "Email marketing", "Organic social media posts", "Pay-per-click ads", "Content marketing" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What is the primary purpose of a call-to-action (CTA)?", Options = new List<string> { "To generate leads", "To improve website design", "To attract traffic", "To track website analytics" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which tool is commonly used for website analytics?", Options = new List<string> { "Google Ads", "Google Analytics", "Google Search Console", "Google Drive" }, CorrectAnswer = 1 },
                },

                18 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is a key advantage of email marketing?", Options = new List<string> { "Instant revenue generation", "High cost-effectiveness", "Guaranteed lead conversion", "Automatic content generation" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is a metric used to measure email marketing success?", Options = new List<string> { "Cost per click", "Conversion rate", "Open rate", "Bounce rate" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What does 'impressions' refer to in digital marketing?", Options = new List<string> { "Clicks on an ad", "Number of times an ad is viewed", "Engagements with a post", "Shares of a post" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of the following is a type of content marketing?", Options = new List<string> { "Banner ads", "Social media videos", "Infographics", "All of the above" }, CorrectAnswer = 3 },
                },

                19 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the main component that acts as the brain of a robot?", Options = new List<string> { "Sensor", "Controller", "Actuator", "Power Supply" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which type of motor is commonly used in robotic arms?", Options = new List<string> { "DC motor", "Stepper motor", "Servo motor", "AC motor" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What is the primary purpose of a robot's sensor?", Options = new List<string> { "To process data", "To execute commands", "To detect changes in the environment", "To power the robot" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which of the following is an example of an end effector in robotics?", Options = new List<string> { "Robot's wheel", "Robot's arm", "Gripper or claw", "Robot's camera" }, CorrectAnswer = 2 },
                },

                20 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the term for the study of robot motion?", Options = new List<string> { "Kinematics", "Dynamics", "Robotics engineering", "Automation" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "Which programming language is widely used in robotics?", Options = new List<string> { "Python", "Ruby", "PHP", "Swift" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the purpose of an actuator in a robot?", Options = new List<string> { "To sense motion", "To move or control a mechanism", "To analyze data", "To communicate with the user" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is an autonomous robot?", Options = new List<string> { "A robot controlled by humans", "A robot that can perform tasks without human intervention", "A robot used only in factories", "A robot programmed to mimic humans" }, CorrectAnswer = 1 },
                },


                ///////////////////////////////////////////////////////////////////////////////



            };
        }

        public static string GetQuizTitle(int quizId)
        {
            return quizId switch
            {
                1 => "Python Basics",
                2 => "Test your Python knowledge",
                3 => "Cloud security basics",
                4 => "Cloud security basics 2",
                5 => "Mobile app development",
                6 => "Mobile app development 2",
                7 => "Network Administration Basics",
                8 => "Network Administration 2",
                9 => "Game Development with unity",
                10 => "Game Development with unity 2",
                11 => "Introduction to blockchain",
                12 => "Introduction to blockchain 2",
                13 => "Data visualization with tableau",
                14 => "Data visualization with tableau 2",
                15 => "Advanced Java",
                16 => "Advanced Java 2",
                17 => "Digital marketing",
                18 => "Digital marketing 2",
                19 => "Robotics basics",
                20 => "Robotics basics 2",
                _ => "Default Quiz"
            };
        }
    }
}