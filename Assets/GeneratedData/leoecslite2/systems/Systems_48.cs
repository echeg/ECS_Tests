using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component450>().Inc<Component192>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component41>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component41>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component237>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component237>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component455>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component455>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component23>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component23>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
