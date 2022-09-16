import { Photo } from "./photo";

    export interface Member {
        id: number;
        username: string;
        photoUrl: string;
        race: string;
        fullname: string;
        created: Date;
        lastActive: Date;
        gender: string;
        alias: string;
        occupation: string;
        publisher: string;
        groupAffiliation: string;
        relatives: string;
        intelligence: number;
        strength: number;
        speed: number;
        durability: number;
        power: number;
        combat: number;
        photos: Photo[];
    }


