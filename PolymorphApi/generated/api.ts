/* tslint:disable */
/* eslint-disable */
/**
 * PolymorphApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import { Configuration } from './configuration';
import globalAxios, { AxiosPromise, AxiosInstance, AxiosRequestConfig } from 'axios';
// Some imports not used depending on template conditions
// @ts-ignore
import { DUMMY_BASE_URL, assertParamExists, setApiKeyToObject, setBasicAuthToObject, setBearerAuthToObject, setOAuthToObject, setSearchParams, serializeDataIfNeeded, toPathString, createRequestFunction } from './common';
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from './base';

/**
 * 
 * @export
 * @interface Bed
 */
export interface Bed extends Furniture {
    /**
     * 
     * @type {boolean}
     * @memberof Bed
     */
    'floats'?: boolean;
}
/**
 * 
 * @export
 * @interface Chair
 */
export interface Chair extends Furniture {
    /**
     * 
     * @type {string}
     * @memberof Chair
     */
    'type': string;
    /**
     * 
     * @type {boolean}
     * @memberof Chair
     */
    'hasArmRests'?: boolean;
}
/**
 * 
 * @export
 * @interface Furniture
 */
export interface Furniture {
    /**
     * 
     * @type {string}
     * @memberof Furniture
     */
    'type': string;
}
/**
 * 
 * @export
 * @interface Table
 */
export interface Table extends Furniture {
    /**
     * 
     * @type {boolean}
     * @memberof Table
     */
    'isWood'?: boolean;
}
/**
 * 
 * @export
 * @interface WoodenChair
 */
export interface WoodenChair extends Chair {
    /**
     * 
     * @type {string}
     * @memberof WoodenChair
     */
    'woodType'?: string | null;
}

/**
 * FurnitureApi - axios parameter creator
 * @export
 */
export const FurnitureApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getFurniture: async (options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/Furniture`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;


    
            setSearchParams(localVarUrlObj, localVarQueryParameter);
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * FurnitureApi - functional programming interface
 * @export
 */
export const FurnitureApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = FurnitureApiAxiosParamCreator(configuration)
    return {
        /**
         * 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getFurniture(options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<Array<Bed | Chair | Table | WoodenChair>>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getFurniture(options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * FurnitureApi - factory interface
 * @export
 */
export const FurnitureApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = FurnitureApiFp(configuration)
    return {
        /**
         * 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getFurniture(options?: any): AxiosPromise<Array<Bed | Chair | Table | WoodenChair>> {
            return localVarFp.getFurniture(options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * FurnitureApi - object-oriented interface
 * @export
 * @class FurnitureApi
 * @extends {BaseAPI}
 */
export class FurnitureApi extends BaseAPI {
    /**
     * 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FurnitureApi
     */
    public getFurniture(options?: AxiosRequestConfig) {
        return FurnitureApiFp(this.configuration).getFurniture(options).then((request) => request(this.axios, this.basePath));
    }
}


