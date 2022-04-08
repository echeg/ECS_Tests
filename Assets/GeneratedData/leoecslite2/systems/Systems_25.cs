using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System25 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component488>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component434>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component434>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component260>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component260>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component423>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component423>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component328>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component328>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
