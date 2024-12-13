using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Synaptica.Migrations
{
    /// <inheritdoc />
    public partial class AddCompletedPercentageToCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    instructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.instructorId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instructor_instructorId = table.Column<int>(type: "int", nullable: true),
                    completedPercentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseId);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_instructor_instructorId",
                        column: x => x.instructor_instructorId,
                        principalTable: "Instructors",
                        principalColumn: "instructorId");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    commentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timestamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_courseId = table.Column<int>(type: "int", nullable: false),
                    course_instructor_instructorId = table.Column<int>(type: "int", nullable: false),
                    user_userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_Comments_Courses_course_courseId",
                        column: x => x.course_courseId,
                        principalTable: "Courses",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Instructors_course_instructor_instructorId",
                        column: x => x.course_instructor_instructorId,
                        principalTable: "Instructors",
                        principalColumn: "instructorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_user_userId",
                        column: x => x.user_userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    enrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enrollmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    progress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_userId = table.Column<int>(type: "int", nullable: true),
                    course_courseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.enrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_course_courseId",
                        column: x => x.course_courseId,
                        principalTable: "Courses",
                        principalColumn: "courseId");
                    table.ForeignKey(
                        name: "FK_Enrollments_Users_user_userId",
                        column: x => x.user_userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    notificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timestamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_courseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.notificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Courses_course_courseId",
                        column: x => x.course_courseId,
                        principalTable: "Courses",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    quizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    passingScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_courseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.quizId);
                    table.ForeignKey(
                        name: "FK_Quizzes_Courses_course_courseId",
                        column: x => x.course_courseId,
                        principalTable: "Courses",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    questionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quiz_quizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_quiz_quizId",
                        column: x => x.quiz_quizId,
                        principalTable: "Quizzes",
                        principalColumn: "quizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_course_courseId",
                table: "Comments",
                column: "course_courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_course_instructor_instructorId",
                table: "Comments",
                column: "course_instructor_instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_user_userId",
                table: "Comments",
                column: "user_userId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_instructor_instructorId",
                table: "Courses",
                column: "instructor_instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_course_courseId",
                table: "Enrollments",
                column: "course_courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_user_userId",
                table: "Enrollments",
                column: "user_userId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_course_courseId",
                table: "Notifications",
                column: "course_courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_quiz_quizId",
                table: "Questions",
                column: "quiz_quizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_course_courseId",
                table: "Quizzes",
                column: "course_courseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
