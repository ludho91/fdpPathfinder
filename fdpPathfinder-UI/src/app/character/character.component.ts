import { Component, OnInit } from '@angular/core';
import { CharacterService } from '../character.service';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {

  character: any;
  constructor(private characterService: CharacterService) { }

  ngOnInit() {
    this.character = this.getCharacter();
  }

  getCharacter(){
    return this.characterService.getCharacter(2).subscribe();
  }
}
