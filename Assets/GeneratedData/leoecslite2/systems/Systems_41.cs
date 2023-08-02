using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System41 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component397>().Inc<Component171>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component329>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component329>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component61>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component61>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component274>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component274>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component468>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component468>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}