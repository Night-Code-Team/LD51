### Команды для git
git clone ссылка-на-гит = копирует данный репозиторий, Создает папку с названием репозитория и помещает туда все файлы репозитория.

git status = проверяем состояние репоизтория

git branch -a = все существующие ветки, а так же какая ветка сейчас выбрана

git remote - все существующие удаленные репозитории

git fetch = обновляет данные по репозиторию, требуется находиться в директории, где находится репозиторий

git pull название-удаленого-репозиторя название-ветки = если есть новые комиты на сервере, скачивает их в локальный репозиторий

git add * = добавляет все файлы в отслеживание

git commit -F patch.txt = комитит все изменения. Название и описание коммита берется из файла patch.txt

git push название-внешнего-репозитория название-локальной-ветки = отправляет на внешний сервер последние закомиченные изменения