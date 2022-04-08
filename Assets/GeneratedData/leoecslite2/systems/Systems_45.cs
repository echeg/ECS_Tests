using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System45 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component45>().Inc<Component433>().Inc<Component98>().Inc<Component256>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component50>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component50>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component331>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component331>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component11>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component11>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component375>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component375>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
