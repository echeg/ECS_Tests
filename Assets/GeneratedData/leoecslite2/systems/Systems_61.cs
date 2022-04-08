using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System61 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component495>().Inc<Component464>().End();
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
   if (_world.GetPool<Component116>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component116>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component171>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component171>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component422>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component422>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
