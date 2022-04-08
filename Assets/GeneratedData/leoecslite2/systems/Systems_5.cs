using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component282>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component280>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component280>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component211>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component211>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component481>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component481>().Get(entity);
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
  }
 }
}

}
