import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class CharacterService {

    private baseUrl = 'http://localhost:5000/character/';

    constructor(private http: HttpClient) { }

    getCharacter(id: number){
        console.log('lourd');
        return this.http.get(this.baseUrl + id);
    }

}
