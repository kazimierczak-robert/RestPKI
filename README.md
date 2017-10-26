# RestPKI


## REST Django Server
Python wersja powyżej 3
Instalacja potrzebnych bibliotek
- pip install Django (lub pip3, trzeba sprawdzić, który pip jest od Pythona 3)

Uruchamianie serwera
- przechodzimy do katalogu z plikiem manage.py
- python manage.py runserver

Ja korzystam jeszcze ze środowisk wirtualnych dla Pythona, dzięki którym mogę mieć wiele wresji różnych bilbiotek i wiele wersji samego Pythona.
Polega to na tym, że tworzę katalog, w którym mam całe środowisko Pythona wraz z bibliotekami, potem podłączam sie do tego środowiska i mam.
Potem jak środowisko nam niepotrzebne to usuwamy katalog i już. Katalogu ze środowiskiem nie można przenosić, jak już utworzymy je w jednym miejscu to tam musi być.
Po przeniesieniu nie będzie działało.
Instalacja (piszę z głowy, więc może nie pyknąć):
- pip install virtualenv
- przechodzę do katalogu gdzie chce mieć środowisko (dla tego projektu stworzyłem go sobie w tym samym miejscu, w którym mam projekt sklonowany z githuba)
- virtualenv -p python3 venv/		-> (python3 czyli która wersja - musimy mieć ją w systemie, venv/ czyli nazwa katalogu ze środowiskiem)
- source venv/bin/activate			-> podłączam się do środowiska (znak zachęty konsoli powinien się zmienić) i już można korzystać, instalować pakiety pipem, itp
- deactivate						-> wyjście ze środowiska
- następnym razem zaczynamy juz od source venv/bin/activate

