/// <binding AfterBuild='default' Clean='clean' ProjectOpened='watch' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var del = require('del');
var watch = require('gulp-watch');

var paths = {
	transpiled: ['transpiled/**/*.js', 'transpiled/**/*.map'],
	typescript: ['scripts/**/*.ts'],
	pages: ['pages/**/*.html'],
	styles: ['styles/*']
};

var allPaths = []
	.concat(paths.transpiled)
	.concat(paths.typescript)
	.concat(paths.pages)
	.concat(paths.styles);

gulp.task('clean', function () {
	return	del(['wwwroot/*']);
});

function moveAll() {
	gulp.src(paths.typescript).pipe(gulp.dest('wwwroot/scripts'));
	gulp.src(paths.transpiled).pipe(gulp.dest('wwwroot/scripts'));
	gulp.src(paths.pages).pipe(gulp.dest('wwwroot'));
	gulp.src(paths.styles).pipe(gulp.dest('wwwroot/styles'));
}

gulp.task('default', function () {
	moveAll();
});

gulp.task('watch', function () {
    gulp.watch(allPaths, ['clean', 'default']);
});