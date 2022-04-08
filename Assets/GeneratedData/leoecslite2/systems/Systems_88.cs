using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System88 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component307>().Inc<Component98>().Inc<Component187>().Inc<Component39>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component127>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component127>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component377>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component377>().Get(entity);
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
   if (_world.GetPool<Component385>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component385>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
