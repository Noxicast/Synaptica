﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Synaptica.Data;

#nullable disable

namespace Synaptica.Migrations
{
    [DbContext(typeof(SynpaticaDbContext))]
    [Migration("20241216003041_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Synaptica.Shared.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("commentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_courseId");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("course_instructor_instructorId");

                    b.Property<string>("TimeStamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_userId");

                    b.HasKey("CommentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("courseId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("CompletedPercentage")
                        .HasColumnType("int")
                        .HasColumnName("completedPercentage");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("duration");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("instructor_instructorId");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("enrollmentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_courseId");

                    b.Property<string>("EnrollmentDate")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("enrollmentDate");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("progress");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_userId");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("instructorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("notificationId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_courseId");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message");

                    b.Property<string>("Timestamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("timestamp");

                    b.HasKey("NotificationId");

                    b.HasIndex("CourseId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("quizId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuizId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_courseId");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("duration");

                    b.Property<string>("PassingScore")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("passingScore");

                    b.HasKey("QuizId");

                    b.HasIndex("CourseId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.QuizQuestion", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("questionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("answer");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("question");

                    b.Property<int>("QuizId")
                        .HasColumnType("int")
                        .HasColumnName("quiz_quizId");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Comment", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Synaptica.Shared.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Synaptica.Shared.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Course", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Enrollment", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("Synaptica.Shared.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Notification", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.Quiz", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Synaptica.Shared.Models.QuizQuestion", b =>
                {
                    b.HasOne("Synaptica.Shared.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });
#pragma warning restore 612, 618
        }
    }
}
