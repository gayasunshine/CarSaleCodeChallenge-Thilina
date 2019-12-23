export enum Vehicletypes {
    Car
}

export namespace Vehicletypes {

    export function values() {
        return Object.keys(Vehicletypes).filter(
            (type) => isNaN(<any>type) && type !== 'values'
        );
    }
}
