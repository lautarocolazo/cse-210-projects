Console.WriteLine("Hello, World!");

Job job1 = new Job("Software Engineer", "Google", 2022, 2023);
Job job2 = new Job("Software Engineer", "Amazon", 2023, 2024);

Resume resume1 = new Resume("Lautaro");

resume1.AddJobToResume(job1);
resume1.AddJobToResume(job2);

resume1.DisplayResume();
