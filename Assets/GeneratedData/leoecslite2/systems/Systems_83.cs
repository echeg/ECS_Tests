using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System83 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component88>().Inc<Component297>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component219>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component219>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component392>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component392>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component498>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component498>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component353>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component353>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
