# Unity Tutorium
Dieses Projekt wurde im Rahmen eines Tutoriums an der Hochschule Furtwangen zur Einführung in Unity erstellt.

## 1 Szenen, Objekte und Komponenten
Eine Szene in Unity ist eine Menge von Objekten, die in einer Baumstruktur angeordnet sind. Wenn eine Szene erstellt wird, oder auch die <i>SampleScene</i> mit der ein Projekt beginnt, dann enthält diese bereits zwei Objekte. Jeweils eine <i>Main Camera</i> und ein <i>Directional Light</i>. Die Kamera nimmt das Bild im Spiel auf und das Licht simuliert die Sonne.

![](Images/NewSceneHierarchy.png)

Wenn wir ein Objekt einer Szene hinzufügen wollen geht das über den <b>+</b>-Button vom <i>Hierarchy</i>-Fenster oder Rechtscklick in das Fenster hinein. Dann gibt es die Auswahl zwischen einem leerem Objekt und unterschiedlichen Kategorien von Objekten. Dreidimensionale Körper können in der Kategorie <i>3D Object</i> gefunden werden.

![](Images/Add3DObject.png)

Objekte in einer Szene können untergeordnete Objekte haben, daher die Baumstruktur. Wenn wir einem Objekt ein untergeordnetes Objekt hinzufügen wollen, ist das über Rechtsklick auf das Objekt im <i>Hierarchy</i>-Fenster möglich oder wir ziehen per Drag-and-Drop ein bestehendes Objekt auf ein anderes. Wenn wir Objekte verschieben, drehen oder skalieren wollen, geht das entweder über die Werkzeuge im Szenenfenster oder über die Eigenschaften <i>Position</i>, <i>Rotation</i> und <i>Scale</i> in der <i>Transform</i>-Komponente eines Objekts. Wenn wir Objekten unterschiedliche Farben oder allgemein Oberflächen verpassen wollen, können wir im Projektfenster <i>Materials</i> erstellen und diese per Drag-and-Drop auf das jeweilige Objekt ziehen. Das erstellen von Materials oder anderen Assets im Projektfenster geht über den <b>+</b>-Button, oder indem wir in einem Ordner Rechtsklicken und auf <i>Create</i> gehen. Jetzt können wir zum Beispiel eine Szene mit Würfeln wie in der folgenden Abbildung aufbauen.

![](Images/Scene1.png)

Diese Szene ist bis jetzt noch statisch. Selbst wenn wir im Unity-Editor auf den Play-Button drücken, passiert nichts. In Unity können Objekten über Komponenten Funktionalität hinzugefügt werden. Tatsächlich besitzen die Objekte in dieser Szene schon Komponenten. Die <i>Main Camera</i> hat die Komponenten <i>Camera</i> und <i>Audio Listener</i>, das <i>Direction Light</i> hat die Komponente <i>Light</i> und unsere Würfel haben die Komponenten <i>Mesh Filter</i>, <i>Mesh Renderer</i>, <i>Box Collider</i> und <i>Material</i>. Außerdem hat jedes <i>GameObject</i> in Unity immer eine <i>Transform</i>-Komponente. Wenn wir eine Komponente hinzufügen wollen geht das mit dem <i>Add Component</i>-Button nach der letzten Komponente eines Objekts.

![](Images/AddComponent.png)

Wenn wir jetzt zum Beispiel den Boden drehen lassen wollen, können wir nach einer Komponente <i>RotationAnimator</i> suchen. So eine Komponente gibt es nicht Unity, aber wir haben die möglichkeit über den Button <i>New script</i> ein neues C#-Skript zu erstellen und dieses direkt als Komponente dem Objekt hinzuzufügen. Wenn wir das gemacht haben, finden wir jetzt das Skript auch in dem Projektfenster unter dem Ordner <i>Assets</i>. Hier können wir auf gleiche weise wie <i>Materials</i> auch Ordner erstellen. So kann auch ein Ordner für die C#-Skripte erstellt werden um unser Projekt etwas organisierter zu halten. Mit Doppelklick auf das Skript im Projektfenster oder Klick auf die Pünktchen von der Komponente im <i>Ispector</i> und Auswahl von <i>Edit Script</i>, kann das Skript zur Bearbeitung geöffnet werden. Ein neues Skript sieht vorerst wie in der folgenden Abbildung aus.

![](Images/RotationAnimator1.png)

Wir sehen hier eine Klasse mit dem Namen <i>RotationAnimator</i> wie wir angegeben haben und diese erbt von der Klasse <i>MonoBehaviour</i>, veranschaulicht durch den Doppelpunkt. Durch die Vererbung wird der Klasse alle Grundfunktionalitäten für Skripte in Unity gegeben. Zum Beispiel sind die Methoden <i>Start</i> und <i>Update</i> von MonoBehaviour geerbt. Wichtig zu verstehen ist hier aber erstmal nur wann die Methoden aufgerufen werden. Das steht praktischerweise am Anfang jeweils in der Kommentarzeile über der Methode. Kommentare können in C# mit <i>//</i> angeführt werden. Dadurch wird alles was dahintersteht bei der Ausführung ignoriert und dient somit nur als Information für den Entwickler. Um ein Objekt dauerhaft drehen zu lassen können wir von der <i>Transform</i>-Komponente die <i>Rotate</i>-Methode aufrufen, wie in der folgenden Abbildung zu sehen.

![](Images/RotationAnimator2.png)

Dabei wird, wenn wir runde Klammer auf schreiben, eine Beschreibung der Methode dargestellt bei der wir auch die Parameter sehen. Parameter sind Variablen, die wir in den Runden Klammern an eine Methode übergeben können. In der Regel müssen alle erwarteten Parameter auch übergeben werden, jedoch gibt es sogenannte Überladungen von Methoden. Das sind andere implementierungen einer Methode mit mehr, weniger oder ganz anderen Parametern. So können wir hier auch nur den ersten Parameter <i>eulers</i> angeben. Hier wird ein Objekt des Typs <i>Vector3</i> erwartet. Ein solches Objekt können wir mit <i>new Vector3()</i> erzeugen. Wenn wir hier die Klammer öffnen und eine <i>0</i> schreiben, dann sehen wir die Beschreibung einer Konstruktorüberladung mit drei Parametern <i>x</i>, <i>y</i> und <i>z</i>. Ein Konstruktor ist eine Methode zur Erzeugung eines Objekts von dem entsprechenden Typ. Diese Variante können wir verwenden, um das Objekt zum Beispiel bei jedem <i>Update</i>-Aufruf um 5° um die y-Achse drehen zu lassen.

![](Images/RotationAnimator3.png)

Wenn wir jetzt im Unity-Editor den Play-Button drücken, sehen wir wie sich der Boden mit unserer <i>RotationAnimator</i>-Komponente dreht. Wir sehen auch, dass sich die Würfel auf dem Boden mitrotieren. Das liegt daran, dass sie dem Boden untergeordnet wurden, sie also Kinder des Bodens sind. Dadurch wird die Transformation des Bodens auf die der Würfel übertragen, während die Würfel aber auch individuell relativ zum Boden transformiert sein können. Wir auch einem der Würfel die <i>RotationAnimator</i>-Komponente hinzufügen, dann sehen wir, wie sich der Würfel mit dem Boden rotiert und zusätzlich auf dem Boden rotiert. Jetzt besteht aber das Problem, dass die Geschwindigkeit der Drehung davon abhängt, wie Oft das Bild pro Sekunde aktualisiert wird. Um dieses Problem zu beheben können wir den Vektor, welchen wir an <i>transform.Rotate</i> übergeben, mit <i>Time.deltaTime</i> multiplizieren. <i>Time</i> ist eine Klasse die Unity liefert und die Eigenschaft <i>deltaTime</i> liefert immer die Zeit in Sekunden die vom letzten Frame bis zum Aktuellen vergangen ist. Wenn wir jetzt die Szene abspielen, dreht sich der Würfel langsamer, da die Zeit zwischen zwei Frames weniger als eine Sekunde beträgt. Wir könnten die Geschwindigkeit anpassen, indem wir bei dem Vektor anstatt eine <i>5</i> eine höhere Zahl eintragen, doch wenn die Geschwindigkeit auch noch in Zukunft angepasst wird, müssten wir das Skript jedes Mal neu übersetzen lassen. Beim Übersetzen wird der für uns leserliche Code zu für den Computer ausführbaren Code übersetzt. Dieser Prozess kann viel Zeit kosten, vor Allem wenn häufig neu übersetzt werden muss. Um das zu umgehen können wir der Komponente ein Feld geben, das wir auch im Unity-Editor bearbeiten können. Eine solches Feld kann im Skript mit dem Schlüsselwort <i>public</i> angeführt werden. <i>public</i> steht hier dafür, dass das Feld nach außen hin sichtbar ist, also dass andere Objekte das Feld sehen können. Öffentliche Felder werden von Unity auch im Editor sichtbar gemacht. Nach <i>public</i> wird ein Datentyp erwartet. Wir wollen hier eine Geschwindigkeit als Feld definieren und dafür eignet sich eine Fließkommazahl, also geben wir <i>float</i> für <i>floating number</i> an. Dann wird nur noch ein Name für das Feld erwartet. Das Feld sollte dann wie folgt im Skript definiert sein.

![](Images/RotationAnimator4.png)

Jetzt müssen wir nur noch den Vektor für die Drehung mit dem neuen Feld <i>speed</i> multiplizieren. Gehen wir zurück zum Unity-Editor sehen wir das Feld <i>speed</i> und wir sollten den Wert auf etwas anderes als 0 ändern, damit sich unser Boden dreht.

![](Images/RotationAnimator5.png)

Wird jetzt die Szene abgespielt dreht sich unser Würfel mit konstanter Geschwindigkeit egal wie schnell die Frames vom Computer berechnet werden. Wir haben außerdem die Möglichkeit während die Szene abgespielt wird das Feld <i>speed</i> zu verändern und sehen direkt den Effekt, also wie sich der Würfel mit der neuen Geschwindigkeit dreht. Um nochmal zu dem Prinzip von untergeordneten Objekten zurückzukehren können wir jetzt auch dem Würfel, der relativ zum Boden rotiert, eine negative Geschwindigkeit geben, sodass dieser sich nicht mehr relativ zur Kamera dreht sondern nur noch verschiebt. Dann sollte der entsprechende Würfel immer richtung Kamera schauen, wie in der folgenden Abbildung zu sehen.

![](Images/Scene1_2.png)


## 2 Physik und Prefabs

Wir haben ja schon gesehen, dass die Würfel, welche wir erstellt haben, <i>Box Collider</i> besitzen. Wir wissen aber noch nicht was sie tun. <i>Collider</i> im allgemeinen werden dazu verwendet zu erkennen, wann Objekte sich berühren. Das ist wichtig um für bewegliche Objekte Hindernisse schaffen zu können. Zum Beispiel wenn wir einen Spielercharakter implementieren wollen müssen wir wissen wann der Charakter anhalten muss, weil eine Wand im Weg ist. Aber auch wenn ein Flummi durch die Szene hüpfen soll sind <i>Collider</i> wichtig, damit der Flummi weiß, wann er abprallen soll. Bis jetzt bewegen sich aber nur die animierten Würfel in unserer Szene und nichts wird von einer Gravitation nach unten gezogen. Um einen frei beweglichen Körper, der an anderen Objekten abprallt, zu simulieren, wie einen Flummi, gibt es in Unity eine weitere Komponente, die <i>Rigidbody</i>-Komponente. Bevor wir aber die Szene verändern, machen wir erst eine Kopie mit <i>strg</i>+<i>d</i> oder <i>strg</i>+<i>c</i> und <i>strg</i>+<i>v</i>. Diese nennen wir dann <i>Szene 2</i> für das zweite Kapitel. In der Kopie können wir dann eine Kugel einfügen, die automatisch mit einem <i>Collider</i> einhergeht und dieser eine <i>Rigidbody</i>-Komponente hinzufügen. Wenn wir sie mit etwas Abstand über den Boden setzen und die Szene abspielen, sehen wir, wie die Kugel abprallt. Jetzt springt die Kugel aber noch nicht wie ein Flummi. Um das zu erreichen müssen wir ein <i>Physic Material</i> erstellen. Hierbei handelt es sich um ein Asset und somit können wir das im Projektfenster erstellen. Im <i>Physic Material</i> können wir die <i>Bounciness</i> als auch andere Eigenschaften einstellen. Dieser Wert geht von 0 bis 1, wenn uns das noch nicht reicht, können wir auch die Methode ändern, wie das Federlevel der beiden kombiniert wird. Das neue Material müssen wir dann beim <i>Collider</i> auswählen. Unsere Kugel kann dann wie folgt konfiguriert sein.

![](Images/BounceBall.png)

Was uns jetzt vielleicht noch auffällt ist die Checkbox für <i>Is Trigger</i> beim <i>Collider</i>. Wenn wir dieses Feld aktivieren, dann wird das Objekt nicht mehr als solides Objekt behandelt sondern als ein begehbarer Raum, welcher aber auf <i>Collider</i> reagiert, die in den Raum rein oder raus gehen. Wir können Mal einen neuen Würfel erstellen bei den wir den <i>Collider</i> zu einem <i>Trigger</i> umschalten. Um zu veranschaulichen, dass der Würfel begehbar ist, erstellen wir ein neues transparentes Material, das wir dem Würfel geben. Wenn jetzt also unser Flummi in den Trigger fliegt, wird er ausgelöst, jedoch haben wir noch nicht implementiert, was in so einem Fall passieren soll. Dafür erstellen wir eine neue Komponente, die wir <i>TriggerListener</i> nennen. Dort wollen wir nicht mehr auf die Ereignisse <i>Start</i> und <i>Update</i> reagieren, also können wir diese Methoden entfernen. Stattdessen fügen wir zwei andere Methoden ein, nämlich <i>OnTriggerEnter</i> und <i>OnTriggerExit</i>. Damit wir ein Feedback bekommen, wenn diese Ereignisse eintreten können wir Debug-Ausgaben einfügen. Das geschieht mit der <i>Log</i>-Methode der von Unity gelieferten Debug-Klasse. Die folgende Abbildung zeigt wie diese Ausgaben aussehen können.

![](Images/TriggerListener1.png)

Wenn wir jetzt die Szene starten und den Flummi in den <i>Trigger</i> fliegen lassen, sehen wir im Fenster der Konsole, dass Ausgaben erfolgen.

![](Images/TriggerListener2.png)

Jetzt haben wir eine Ausgabe, wenn der <i>Trigger</i> ausgelöst wird aber sonst passiert aktuell noch nichts. Wenn wir wollen das ein Objekt verschwindet oder ein Feuerwerk ausgelöst wird, wenn sich ein Objekt in den <i>Trigger</i> hineinbewegt, dann könnten wir das fest als Teil der <i>TriggerListener</i>-Komponente implementieren. Alternativ haben wir aber auch die Möglichkeit einen <i>TriggerListener</i> zu implementieren bei dem erst im Unity-Editor festgelegt wird was beim Eintreten von <i>TriggerEnter</i> und <i>TriggerExit</i> geschehen soll. Hier kommen <i>UnityEvents</i> ins Spiel. <i>UnityEvents</i> können als Felder angelegt werden und werden im Editor sichtbar wie wir es schon mit der Geschwindigkeit vom <i>RotationAnimator</i> gemacht haben. Hierbei wird aber keine Fließkommazahl definiert sondern eine Liste von Methoden festgelegt, die ausgeführt werden sollen, wenn das jeweilige Ereignis eintritt. Wir fügen dem Skript also zwei neue Felder <i>TriggerEnterResponse</i> und <i>TriggerExitResponse</i> vom Typ <i>UnityEvent</i> hinzu. Diese können wir dann in den Entsprechenden Methoden, die bis jetzt nur eine Debug-Ausgabe enthalten, auslösen, indem wir jeweils deren <i>Invoke</i>-Methode aufrufen. Das sollte dann wie folgt aussehen.

![](Images/TriggerListener3.png)

Im Unity-Editor können wir jetzt Methoden auswählen die als Antwort auf die Ereignisse ausgeführt werden sollen. Dazu drücken wir den <b>+</b>-Button des jeweiligen Ereignises um einen neuen Eintrag hinzuzufügen. Dort wird als erstes ein Objekt verlangt, von dem wir die Methode ausführen wollen. Zum Testen können wir zum Beispiel die Farbe des Triggers ändern lassen. Dazu ziehen wir per Drag-and-Drop den Trigger selbst als Objekt in den Eintrag und wählen als Methode vom <i>MeshRenderer</i> die Eigenschaft <i>material</i> aus. Hier können wir jetzt noch einen Wert einstellen auf den dann diese Eigenschaft gesetzt werden soll und dazu brauchen wir erst ein neues <i>Material</i>. Wir kopieren das <i>Material</i> des Triggers und ändern dessen Farbe um dann diese Kopie als Wert zu setzen auf den die Eigenschaft <i>material</i> gesetzt werden soll beim Eintreten von <i>TriggerEnter</i>. Bei <i>TriggerExit</i> können wir diese Eigenschaft wieder auf das ursprüngliche Material setzen.

![](Images/TriggerListener4.png)

Wenn jetzt die Szene abgespielt wird sollte sich die Farbe des Triggers ändern, wenn der Flummi reinfliegt und sich wieder zurücksetzen, wenn er rausfliegt. Im Laufe dieses Kapitels haben wir jetzt zwei neue Arten von Objekte erstellt. Zum einen einen Flummi und eine Trigger-Box. Im letzten Kapitel haben wir außerdem drehende Körper erstellt. Aus all diesen Objekten können wir jetzt Prefabs erzeugen. Dazu können wir diese Objekte in der Szene auswählen und per Drag-and-Drop in das Projektfenster ziehen. Wenn wir jetzt kopien dieser Objekte in einer Szene benötigen können wir dessen Prefabs, die jetzt im Projektordner sichtbar sein sollten, genauso per Drag-and-Drop in die entsprechende Szene ziehen. Der Vorteil den wir jetzt haben ist, dass wir nur noch an einer Stelle, innerhalb des jeweiligen Prefabs, Änderungen vornehmen müssen, wenn wir zum Beispiel das Verhalten des Flummis für alle Kopien in allen Szenen verändern wollen. Jetzt brauchen wir nur noch einen Ordner für die Prefabs. Dorthin kann auch das <i>Physic Material</i> des Flummis verschoben werden.

![](Images/PrefabFolder.png)

## 3 Character Movement

## 4 Scriptable Objects

## 5 High Definition RP und Visual Effect Graph

## 6 Post Processing

## 7 GPU-Events

## 8 Shader Graph

## 9 Shader Graph und Visual Effect Graph
