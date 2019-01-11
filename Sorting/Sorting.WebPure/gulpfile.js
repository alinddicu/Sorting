/// <binding AfterBuild='default' Clean='clean' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var del = require('del');

var paths = {
	transpiled: ['transpiled/**/*.js', 'transpiled/**/*.map'],
	typescript: ['scripts/**/*.ts'],
	pages:['pages/**/*.html']
};

gulp.task('clean', function () {
	return	del(['wwwroot/scripts/**/*']);
});

gulp.task('default', function () {
	gulp.src(paths.typescript).pipe(gulp.dest('wwwroot/scripts'));
	gulp.src(paths.transpiled).pipe(gulp.dest('wwwroot/scripts'));
	gulp.src(paths.pages).pipe(gulp.dest('wwwroot'));
});