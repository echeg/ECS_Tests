using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component64>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component166>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component166>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component153>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component153>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component145>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component145>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component478>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component478>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
