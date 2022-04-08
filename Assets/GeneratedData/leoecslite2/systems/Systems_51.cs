using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System51 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component370>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component85>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component85>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component318>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component318>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component144>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component144>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component142>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component142>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
