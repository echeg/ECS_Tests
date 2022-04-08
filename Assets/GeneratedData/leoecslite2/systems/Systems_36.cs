using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System36 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component448>().Inc<Component231>().Inc<Component224>().Inc<Component288>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component53>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component53>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component296>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component296>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component326>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component326>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component345>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component345>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
