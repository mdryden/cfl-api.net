
var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
var nuget = require("gulp-nuget");


gulp.task("build-release", function() {
	return gulp.src("./cfl-api.Net.sln")
		.pipe(msbuild({
			targets: ["Clean", "Build"],
			toolsVersion: 15.0,
			properties: { Configuration: "Release" }
		}));
});

gulp.task("nuget-pack", function () {
	return gulp.src("src/Core/Core.csproj")
		.pipe(nuget.pack());
});