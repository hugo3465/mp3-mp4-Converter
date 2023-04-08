const fs = require('fs');
const ytdl = require('ytdl-core');
const yargs = require("yargs"); // Add Support for Command Line Argumen

const options = yargs /* Opções do yargs */
    .usage("Usage: -n <name>")
    .option("n", { alias: "name", describe: "Your name", type: "string", demandOption: false })
    .option("s", { alias: "search", describe: "Search term", type: "string" })
    .argv;


/*
    Install a mp3 file
*/

let savePath = 'C:/Users/Utilizador/Desktop';

yargs.command({

    command: "mp3",
    describe: 'Install mp3 files from Youtube',
    builder: {
        url: {
            describe: 'url',
            demandOption: true,  // Required
            type: 'string'
        },

        path: {
            describe: 'path',
            demandOption: true,  // Required
            type: 'string'
        }
    },

    // Function for your command
    handler(argv) {

        (async () => {
            let path = argv.path;
            path = path.replace(/"/g, '\\"'); // Replacing \ to /

            let videoUrl = argv.url;
            videoUrl = videoUrl.split('&')[0]; // Removing not necessary variables in url if they exist

            let info = await ytdl.getBasicInfo(videoUrl);
            let videoName = info.videoDetails.title.replace(/[^a-zA-Z ]/g, ""); // Replace serve for deleting the special caracters

            // Dowload with progress bar 
            ytdl(videoUrl)
                .on('response', function (res) {
                    var ProgressBar = require('progress');

                    bar = new ProgressBar('downloading [:bar] :percent :etas', {

                        complete: String.fromCharCode(0x2588),
                        total: parseInt(res.headers['content-length'], 10)

                    });
                })
                .on('data', function (data) {

                    bar.tick(data.length);

                })
                .on('finish', function () { console.log('Download finished...'); })
                .pipe(fs.createWriteStream(path + '/' + videoName + '.mp3'));
        })()

    }

})
yargs.parse() // To set above changes


/*
    Install a mp4 file
*/
yargs.command({
    command: "mp4",
    describe: 'Install mp4 files from Youtube',
    builder: {
        url: {
            describe: 'url',
            demandOption: true,  // Required
            type: 'string'
        },

        path: {
            describe: 'path',
            demandOption: true,  // Required
            type: 'string'
        }
    },

    // Function for your command
    handler(argv) {

        (async () => {
            let path = argv.path;
            path = path.replace(/"/g, '\\"'); // Replacing \ to /
            console.log(path);

            let videoUrl = argv.url;
            videoUrl = videoUrl.split('&')[0]; /* Removing not necessary variables in url if they exist */

            let info = await ytdl.getBasicInfo(videoUrl);
            let videoName = info.videoDetails.title.replace(/[^a-zA-Z ]/g, ""); /* Replace serves for deleting the special caracters */

            // Dowload with progress bar
            ytdl(videoUrl).on('response', function (res) {
                var ProgressBar = require('progress');

                bar = new ProgressBar('downloading [:bar] :percent :etas', {

                    complete: String.fromCharCode(0x2588),
                    total: parseInt(res.headers['content-length'], 10)

                });
            })
                .on('data', function (data) {

                    bar.tick(data.length);

                })
                .on('finish', function () { console.log('Download finished...'); })
                .pipe(fs.createWriteStream(path + '/' + videoName + '.mp4'));
        })()

    }

})
yargs.parse() // To set above changes