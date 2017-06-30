
var videotest;
var canvas;

window.onload = function () {
    videotest = document.getElementById("testvideo");
    canvas = document.getElementById("cadr");
    WriteVolume();
    WritePlaybackRate();
    WriteTime();
    WriteDuration();
    /*Метаданные были загружены или изменены, что указывает на изменение в продолжительности медиа.
	Может быть отправлено, например, когда медиа загружено достаточно для того, чтобы продолжительность уже была известна.*/
    videotest.addEventListener("canplay", WriteDuration);
    //Отправляется, когда изменяется значение атрибута currentTime.
    videotest.addEventListener("timeupdate", WriteTime);
    //Отправляется, когда изменяется скорость воспроизведения.
    videotest.addEventListener("ratechange", WritePlaybackRate);
    //Отправляется, когда изменяется громкость звука (также когда звук включен или выключен).
    videotest.addEventListener("volumechange", WriteVolume);
}

function WriteVolume() {
    document.getElementById("volume").innerHTML = Number(videotest.volume).toFixed(1);
}

function WritePlaybackRate() {
    document.getElementById("playbackrate").innerHTML = Number(videotest.playbackRate).toFixed(1);
}

function WriteTime() {
    document.getElementById("currenttime").innerHTML = Number(videotest.currentTime).toFixed(6);
}

function WriteDuration() {
    document.getElementById("duration").innerHTML = Number(videotest.duration).toFixed(6);//округление до 6 знака после запятой
}

//для контроля воспроизведения
function video_volume_add() { if (videotest.volume < 1) videotest.volume += 0.1; }
function video_volume_sub() { if (videotest.volume > 0) videotest.volume -= 0.1; }
function video_stop() { videotest.pause(); }
function video_start() { videotest.play(); }
function video_rate_add() { videotest.playbackRate = (videotest.playbackRate + 0.1) }
function video_rate_sub() { videotest.playbackRate = (videotest.playbackRate - 0.1); }
function video_pos_add() { videotest.currentTime = (videotest.currentTime + 10); }
function video_pos_sub() { videotest.currentTime = (videotest.currentTime - 10); }

function video_screen() {
    //canvas.width=videotest.width;
    //canvas.height=videotest.height;
    var context = canvas.getContext("2d");
    context.drawImage(videotest, 0, 0, canvas.width, canvas.height);
}

function video_camera() {

    var logs = videotest = document.getElementById("vebcam_log");
    navigator.getUserMedia = (navigator.getUserMedia || navigator.webkitGetUserMedia ||
							navigator.mozGetUserMedia || navigator.msGetUserMedia);
    if (navigator.getUserMedia) {
        logs.innerHTML = "has getUserMedia";
        navigator.getUserMedia({ audio: false, video: true },
            function (stream) {
                logs.innerHTML += "enabled";
                document.getElementById("testvideo").pause();
                document.getElementById("testvideo").src = window.URL.createObjectURL(stream);
                videotest = document.getElementById("testvideo");
                document.getElementById("testvideo").play();
            },
            function () {
                logs.innerHTML += "error";
            }
        );
    }
}