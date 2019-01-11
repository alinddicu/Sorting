/// <binding AfterBuild='default-bundle' Clean='clean-bundle' ProjectOpened='watch-bundle' />
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

gulp.task('clean-bundle', function () {
	return	del(['built-dev/*']);
});

function moveAll() {
	gulp.src(paths.typescript).pipe(gulp.dest('built-dev/scripts'));
	gulp.src(paths.transpiled).pipe(gulp.dest('built-dev/scripts'));
	gulp.src(paths.pages).pipe(gulp.dest('built-dev'));
	gulp.src(paths.styles).pipe(gulp.dest('built-dev'));
}

gulp.task('default-bundle', function () {
	// wait for all files to build before bundling
	setTimeout(function() {
		moveAll();
	}, 500);
});

gulp.task('watch-bundle', function () {
    gulp.watch(allPaths, ['clean-bundle', 'default-bundle']);
});